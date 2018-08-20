using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace crasher.Listeners
{
    public class Server
    {
        public int Port { get; set; }
        public IPAddress IpAddress{ get; set; }

        public Server(string ipAddress, int port)
        {
            Console.WriteLine("PARAMETERS: " + ipAddress + " " + port);
            if(ipAddress != null)
            {
                if(port <= 0)
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
            
        }

        public Server(IPAddress ipAddress,int port) 
        {

            Console.WriteLine("PARAMETERS: " + ipAddress + " " + port);
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
        }


        private static TcpListener server;
        public void StartListening()
        {
            server = new TcpListener(IpAddress, 6969);
            try
            {
                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... " + Environment.NewLine);

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        //
                        // SEND BACK A RESPONSE TO THE CLIENT
                        //

                        // Process the data sent by the client.
                        data = "The server has recived this message : '" + data + "'";

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent back to client: {0}", data);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("IOException: {0}", e.Message);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e.Message);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }
        }
        
        public void StartListeningAsync()
        {
            Thread listener = new Thread(StartListening);
            listener.Start();
        }

        
    }
}
