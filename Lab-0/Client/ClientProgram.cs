using System;
using System.Net.Sockets;

namespace Client
{
    class ClientProgram
    {

        static byte[] Serialize(String input)
        {
            byte[] mybyte = new byte[input.Length];
            mybyte = System.Text.Encoding.ASCII.GetBytes(input);
            return mybyte;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client Program.");

            TcpClient client = new TcpClient();
            client.Connect("localhost", 5002);

            NetworkStream ns = client.GetStream();
            byte[] mys = Serialize("Just a simple message passing through, woo!");
            ns.Write(mys, 0, mys.Length);
            ns.Flush();

        }
    }
}
