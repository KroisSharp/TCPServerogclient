using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPclient
{
    class Program
    {
        private const int PORT = 9000;

        static void Main(string[] args)
        {


            Console.WriteLine("jeg er Client");
            TCPmyClient client = new TCPmyClient(PORT);
            client.Start();


            Console.ReadLine();
        }
    }
}
