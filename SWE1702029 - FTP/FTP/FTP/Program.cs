using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace FTP
{
    class FTP
    {
        private TcpListener _listener;

        public FTP()
        {
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, 21);
            _listener.Start();
            Console.WriteLine("Server is being started.");
            _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);

        }

        public void Stop()
        {
            //force the listener to block the other incoming connections if it has already been listening to a connection
            if (_listener != null)
            {
                _listener.Stop();
            }
        }

        private void HandleAcceptTcpClient(IAsyncResult result)
        {
            _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener); //Initialize to receive connection
            TcpClient client = _listener.EndAcceptTcpClient(result); //Accepts incoming connection

            ClientConnection connection = new ClientConnection(client); //Declare local varaible 'connection' as an object to indicates the connection

            ThreadPool.QueueUserWorkItem(connection.HandleClient, client); //Queues 'HandleClient' method for execution and pass the connection details (IP & port) to the method
        }
    }

    public class ClientConnection
    {
        private TcpClient _controlClient;

        private NetworkStream _controlStream;
        private StreamReader _controlReader;
        private StreamWriter _controlWriter;

        private string password = "xmum";
        private string username = "nsk";

        private TcpListener _passiveListener;
        private TcpClient _dataClient;
        private string _currentDirectory = "C:\\Users\\test"; //set the file directories of the server
        private StreamReader _dataReader;
        private StreamWriter _dataWriter;
        private DataConnectionType _dataConnectionType = DataConnectionType.Passive;
        private IPEndPoint _dataEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 21); //set the data end point (IP and port)
        private string _root = "\\C:\\";
        private string transferType;
        private byte[] address;
        private short port;

        public ClientConnection(TcpClient client)
        {
            _controlClient = client;

            _controlStream = _controlClient.GetStream();

            _controlReader = new StreamReader(_controlStream);
            _controlWriter = new StreamWriter(_controlStream);

            IPAddress localAddress = ((IPEndPoint)_controlClient.Client.LocalEndPoint).Address;
            _passiveListener = new TcpListener(localAddress, 0);
            _passiveListener.Start();
        }

        public void HandleClient(object obj)
        {
            _controlWriter.WriteLine("220 Service Ready.");
            _controlWriter.Flush();
            string line;

            try
            {
                while (!string.IsNullOrEmpty(line = _controlReader.ReadLine()))
                {
                    string response = null;

                    string[] command = line.Split(' ');

                    string cmd = command[0].ToUpperInvariant();
                    string arguments = command.Length > 1 ? line.Substring(command[0].Length + 1) : null;

                    if (string.IsNullOrWhiteSpace(arguments))
                        arguments = null;

                    if (response == null)
                    {
                        switch (cmd)
                        {
                            case "USER":
                                response = User(arguments);
                                break;
                            case "PASS":
                                response = Password(arguments);
                                break;
                            case "CWD":
                                response = ChangeWorkingDirectory(arguments);
                                break;
                            case "CDUP":
                                response = ChangeWorkingDirectory("..");
                                break;
                            case "PWD":
                                response = "257 \"/\" is current directory.";
                                break;
                            case "QUIT":
                                response = "221 Service closing control connection";
                                break;
                            case "TYPE":
                                string[] splitArgs = arguments.Split(' ');
                                response = Type(splitArgs[0], splitArgs.Length > 1 ? splitArgs[1] : null);
                                break;
                            case "PORT":
                                response = Port(arguments);
                                break;
                            case "PASV":
                                response = Passive();
                                break;
                            case "LIST":
                                response = List(_currentDirectory);
                                break;
                            case "RETR":
                                response = Retrieve(arguments);
                                break;
                            case "STOR":
                                response = Store(arguments);
                                break;
                            default:
                                response = "502 Command not implemented";
                                break;
                        }
                    }

                    if (_controlClient == null || !_controlClient.Connected)
                    {
                        break;
                    }
                    else
                    {
                        _controlWriter.WriteLine(response);
                        _controlWriter.Flush();

                        if (response.StartsWith("221"))
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private string Port(string hostPort)
        {
            //will only be used if the connection is active mode
            _dataConnectionType = DataConnectionType.Active;

            string[] ipAndPort = hostPort.Split(',');

            byte[] ipAddress = new byte[4];
            byte[] port = new byte[2];
            Console.WriteLine(ipAddress);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("test");
                ipAddress[i] = Convert.ToByte(ipAndPort[i]);
            }

            for (int i = 4; i < 6; i++)
            {
                port[i - 4] = Convert.ToByte(ipAndPort[i]);
            }

            if (BitConverter.IsLittleEndian)
                Array.Reverse(port);
            _dataEndpoint = new IPEndPoint(new IPAddress(ipAddress), BitConverter.ToInt16(port, 0));

            return "200 Data Connection Established";
        }

        #region FTP Commands

        private string User(string username)
        {
            //check if the input username is same with the defined username in line 59
            username = this.username;
            
            return "331 Username ok, need password";
        }

        private string Password(string password)
        {
            //check if the password is same with the defined password in line 58
            if (password == this.password)
            {
                return "230 User logged in";
            }
            else
            {
                return "530 Not logged in";
            }
        }

        private string ChangeWorkingDirectory(string pathname)
        {
            //uncompleted function that should allow the user to change the remote directory
            return "250 Changed to new directory";
        }

        private string Type(string typeCode, string formatControl)
        {
            //possible data type that FTP can transfer (ASCII, Image, EBCDIC, Local Byte Sizes)
            string response = "500 ERROR"; //response is set as error in default

            switch (typeCode.ToUpperInvariant()) //change the typeCode to uppercase
            {
                case "I":
                    transferType = typeCode;
                    response = "200 OK"; 
                    break;
                case "A":
                    break;
                case "E":
                    break;
                case "L":
                    break;
                default:
                    response = "504 Command not implemented for that parameter.";
                    break;
            }
            if (formatControl != null)
            {
                switch (formatControl)
                {
                    case "N":
                        response = "200 OK";
                        break;
                    case "T":
                        break;
                    case "C":
                        break;
                    default:
                        response = "504 Command not implemented for that parameter";
                        break;
                }
            }
            return response;
        }

        private string Passive()
        {
            IPAddress localAddress = ((IPEndPoint)_controlClient.Client.LocalEndPoint).Address; //store the IP address from client

            _passiveListener = new TcpListener(localAddress, 0);
            _passiveListener.Start();
            IPEndPoint localEndpoint = ((IPEndPoint)_passiveListener.LocalEndpoint);

            address = localEndpoint.Address.GetAddressBytes(); //store the server IP address assigned by the server
            port = (short)localEndpoint.Port; //store the server port number assigned by the server

            byte[] portArray = BitConverter.GetBytes(port); //convert port number into bits form

            if (BitConverter.IsLittleEndian) //to check if the bit converter is little endian or big endian (which depends on the CPU architecture)
                Array.Reverse(portArray);  //if it's little endian, then the portArray has to be reversed so that the correct port number can be reconvert back from bits

            return string.Format("227 Entering Passive Mode ({0},{1},{2},{3},{4},{5})",
                          address[0], address[1], address[2], address[3], portArray[0], portArray[1]);
        }

        private string List(string pathname)
        {
            pathname = NormalizeFilename(pathname);

            if (IsPathValid(pathname))
            {
                if (_dataConnectionType == DataConnectionType.Active)
                {
                    //for active mode ftp connection, client has to inform the server that which port he's listening on by using PORT command 
                    //client listen on random port in active mode
                    _dataClient = new TcpClient();
                    _dataClient.BeginConnect(_dataEndpoint.Address, _dataEndpoint.Port, DoList, pathname);
                }
                else
                {
                    //for passive mode ftp connection, client sends PASV command to retrieve the server IP and port number from the server
                    //client listen on the assigned port in passive mode
                    _passiveListener.BeginAcceptTcpClient(DoList, pathname);
                }

                return string.Format("150 Opening {0} mode data transfer for LIST", _dataConnectionType);
            }

            return "450 Requested file action not taken";
        }

        private void DoList(IAsyncResult result)
        {
            if (_dataConnectionType == DataConnectionType.Active)
            {
                _dataClient.EndConnect(result);
            }
            else
            {
                _dataClient = _passiveListener.EndAcceptTcpClient(result);
            }

            string pathname = (string)result.AsyncState;

            using (NetworkStream dataStream = _dataClient.GetStream())
            {
                _dataReader = new StreamReader(dataStream, Encoding.ASCII);
                _dataWriter = new StreamWriter(dataStream, Encoding.ASCII);

                IEnumerable<string> directories = Directory.EnumerateDirectories(pathname);

                foreach (string dir in directories)
                {
                    DirectoryInfo d = new DirectoryInfo(dir);

                    string date = d.LastWriteTime < DateTime.Now - TimeSpan.FromDays(180) ?
                        d.LastWriteTime.ToString("MMM dd  yyyy") :
                        d.LastWriteTime.ToString("MMM dd HH:mm");

                    string line = string.Format("drwxr-xr-x    2 2003     2003     {0,8} {1} {2}", "4096", date, d.Name);

                    _dataWriter.WriteLine(line);
                    _dataWriter.Flush();
                }

                IEnumerable<string> files = Directory.EnumerateFiles(pathname);

                foreach (string file in files)
                {
                    FileInfo f = new FileInfo(file);

                    string date = f.LastWriteTime < DateTime.Now - TimeSpan.FromDays(180) ?
                        f.LastWriteTime.ToString("MMM dd  yyyy") :
                        f.LastWriteTime.ToString("MMM dd HH:mm");

                    string line = string.Format("-rw-r--r--    2 2003     2003     {0,8} {1} {2}", f.Length, date, f.Name);

                    _dataWriter.WriteLine(line);
                    _dataWriter.Flush();
                }


                _dataClient.Close();
                _dataClient = null;

                _controlWriter.WriteLine("226 Transfer complete");
                _controlWriter.Flush();
            }
        }

        private bool IsPathValid(string pathname)
        {
            //should do some verifications to check the path is valid anot, but I have hardcoded it to ensure it works
            return true;

        }

        private string Retrieve(string pathname)
        {
            pathname = NormalizeFilename(pathname);

            if (IsPathValid(pathname))
            {
                if (File.Exists(pathname))
                {
                    if (_dataConnectionType == DataConnectionType.Active)
                    {
                        //for active mode ftp connection, client has to inform the server that which port he's listening on by using PORT command 
                        //client listen on random port in active mode
                        _dataClient = new TcpClient();
                        _dataClient.BeginConnect(_dataEndpoint.Address, _dataEndpoint.Port, DoRetrieve, pathname);
                    }
                    else
                    {
                        //for passive mode ftp connection, client sends PASV command to retrieve the server IP and port number from the server
                        //client listen on the assigned port in passive mode
                        _passiveListener.BeginAcceptTcpClient(DoRetrieve, pathname);
                    }

                    return string.Format("150 Opening {0} mode data transfer for RETR", _dataConnectionType);
                }
            }

            return "550 File Not Found";
        }

        private string NormalizeFilename(string pathname)
        {
            if (pathname == null)
            {
                pathname = string.Empty;
            }

            if (pathname == "/")
            {
                return _root;
            }
            else if (pathname.StartsWith("/"))
            {
                pathname = new FileInfo(Path.Combine(_root, pathname.Substring(1))).FullName;
            }
            else
            {
                pathname = new FileInfo(Path.Combine(_currentDirectory, pathname)).FullName;
            }

            return IsPathValid(pathname) ? pathname : null;
        }

        private void DoRetrieve(IAsyncResult result)
        {
            if (_dataConnectionType == DataConnectionType.Active)
            {
                _dataClient.EndConnect(result);
            }
            else
            {
                _dataClient = _passiveListener.EndAcceptTcpClient(result);
            }

            string pathname = (string)result.AsyncState;

            using (NetworkStream dataStream = _dataClient.GetStream())
            {
                using (FileStream fs = new FileStream(pathname, FileMode.Open, FileAccess.Read))
                {
                    CopyStream(fs, dataStream); //variable fs tells the method whether it's write or read action is performed against the server
                    _dataClient.Close();
                    _dataClient = null;
                    _controlWriter.WriteLine("226 Closing data connection, file transfer successful");
                    _controlWriter.Flush();
                }
            }
        }
        private static long CopyStream(Stream input, Stream output, int bufferSize)
        {
            //for FTP typecode "I" image
            byte[] buffer = new byte[bufferSize];
            int count = 0;
            long total = 0;

            while ((count = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, count);
                total += count;
            }

            return total;
        }

        private static long CopyStreamAscii(Stream input, Stream output, int bufferSize)
        {
            //for FTP typecode "A" (ASCII)
            char[] buffer = new char[bufferSize];
            int count = 0;
            long total = 0;

            using (StreamReader rdr = new StreamReader(input))
            {
                using (StreamWriter wtr = new StreamWriter(output, Encoding.ASCII))
                {
                    while ((count = rdr.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        wtr.Write(buffer, 0, count);
                        total += count;
                    }
                }
            }

            return total;
        }

        private long CopyStream(Stream input, Stream output)
        {
            if (transferType == "I")
            {
                //if the data type is image
                return CopyStream(input, output, 4096);
            }
            else
            {
                //for other files like .txt would be assumed as ASCII
                return CopyStreamAscii(input, output, 4096);
            }
        }

        private string Store(string pathname)
        {
            pathname = NormalizeFilename(pathname);

            if (pathname != null)
            {
                if (_dataConnectionType == DataConnectionType.Active)
                {
                    //for active mode ftp connection, client has to inform the server that which port he's listening on by using PORT command 
                    //client listen on random port in active mode
                    _dataClient = new TcpClient();
                    _dataClient.BeginConnect(_dataEndpoint.Address, _dataEndpoint.Port, DoStore, pathname);
                }
                else
                {
                    //for passive mode ftp connection, client sends PASV command to retrieve the server IP and port number from the server
                    //client listen on the assigned port in passive mode
                    _passiveListener.BeginAcceptTcpClient(DoStore, pathname);
                }

                return string.Format("150 Opening {0} mode data transfer for STOR", _dataConnectionType);

            }

            return "450 Requested file action not taken";
        }

        private void DoStore(IAsyncResult result)
        {
            if (_dataConnectionType == DataConnectionType.Active)
            {
                _dataClient.EndConnect(result); 
            }
            else
            {
                _dataClient = _passiveListener.EndAcceptTcpClient(result);
            }
            string pathname = (string)result.AsyncState;

            long bytes = 0;
            using (NetworkStream dataStream = _dataClient.GetStream())
            {
                using (FileStream fs = new FileStream(pathname, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 4096, FileOptions.SequentialScan))
                {
                    bytes = CopyStream(dataStream, fs); //variable fs tells the method whether it's write or read action is performed against the server
                    _dataClient.Close();
                    _dataClient = null;
                    _controlWriter.WriteLine("226 Closing data connection, file transfer successful");
                    _controlWriter.Flush();
                }
            }
        }

        #endregion

        #region Enumerations

        private enum DataConnectionType
        {
            Passive,
            Active,
        }

        private enum FileStructureType
        {
            File,
            Record,
            Page,
        }

        private enum FormatControlType
        {
            NonPrint,
            Telnet,
            CarriageControl,
        }

        private enum TransferType
        {
            Ascii,
            Ebcdic,
            Image,
            Local,
        }

        #endregion Enumerations

        static void Main(string[] args)
        {
            FTP ftp = new FTP();
            ftp.Start();
            string quit = "0";
            while (quit == "0")
            {
                Console.WriteLine("Press any key to quit...");
                quit = Console.ReadLine();
            }
        }
    }
}

