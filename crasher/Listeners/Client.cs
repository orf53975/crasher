using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Listeners
{
    public class Client
    {
        public int Port { get; set; }
        public IPAddress IpAddress { get; set; }

        public Client(string ipAddress, int port)
        {
            if (ipAddress != null)
            {
                if (port <= 0)
                {
                    Port = port;

                    try
                    {
                        IpAddress = IPAddress.Parse(ipAddress);
                    }
                    catch (FormatException e)
                    {
                        throw new FormatException("Invalid IPAddress format");
                    }
                }
                else
                {
                    throw new ArgumentNullException("Port parameter can't be null");
                }
            }
            else
            {
                throw new ArgumentNullException("IPAddress parameter can't be null");
            }

            if(!Connect(IpAddress.ToString(), Port))
            {
                throw new SocketException();
            }

        }

        public Client(IPAddress ipAddress, int port)
        {
            if (ipAddress != null)
            {
                if (port <= 0)
                {
                    Port = port;
                    IpAddress = ipAddress;
                }
                else
                {
                    throw new ArgumentNullException("Port parameter can't be " + port);
                }
            }
            else
            {
                throw new ArgumentNullException("IPAddress parameter can't be null");
            }

            if (!Connect(IpAddress.ToString(), Port))
            {
                throw new SocketException();
            }
        }

        private static TcpClient client = null;
        public static string SendMessage(String message)
        {
            // String to store the response ASCII representation.
            String responseData = String.Empty;

            if (client == null)
            {
                throw new NullReferenceException("You have to be connected on a tcp server");
            }
            else
            {
                try
                {
                    // Translate the passed message into ASCII and store it as a Byte array.
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                    // Get a client stream for reading and writing.

                    NetworkStream stream = client.GetStream();

                    // Send the message to the connected TcpServer. 
                    stream.Write(data, 0, data.Length);

                    Console.WriteLine("Sent: {0}", message);

                    // Receive the TcpServer.response.

                    // Buffer to store the response bytes.
                    data = new Byte[256];

                    //
                    // READ THE SERVER RESPONSE
                    //

                    // Read the first batch of the TcpServer response bytes.
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("ArgumentNullException: {0}", e.Message);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e.Message);
                }
                catch (ObjectDisposedException e)
                {
                    Console.WriteLine("ObjectDisposedException: {0}", e.Message);
                }


                return responseData;
            }
        }

        public static bool Connect(string ipAddress, int port)
        {
            try
            {
                client = new TcpClient(ipAddress, port);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
