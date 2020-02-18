using System;
using System.Net.Sockets;

namespace Server
{
    class ServerProgram
    {

        static string DecodeMessage(ref NetworkStream pNetStream)
        {

            String in_string = "";

            byte[] in_buffer = new byte[1024]; //arbitrary buffer size

            do
            {
                pNetStream.Read(in_buffer, 0, in_buffer.Length);
                in_string += System.Text.UTF8Encoding.ASCII.GetString(in_buffer);

            } while (pNetStream.DataAvailable);

            return in_string;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting Server Program.");
            TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 5002);
            listener.Start();

            TcpClient in_client = listener.AcceptTcpClient();
            NetworkStream in_stream = in_client.GetStream();

            String in_str = DecodeMessage(ref in_stream);
            Console.WriteLine(in_str);
            Console.ReadLine();
        }
    }
}
