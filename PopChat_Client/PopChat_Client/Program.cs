using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PopChat_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 4172);
            Console.WriteLine("Conect to server");
            NetworkStream n = client.GetStream();
            Console.WriteLine("Connected");
            string ch = Console.ReadLine();
            byte[] message = Encoding.ASCII.GetBytes(ch);
            n.Write(message, 0,message.Length);
            Console.WriteLine("-----Sent-----");

            client.Close();
            Console.ReadKey();
            

        }
    }
}
