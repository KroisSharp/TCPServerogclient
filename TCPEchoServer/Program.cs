﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPEchoServer
{
    class Program
    {
        private const int PORT = 9000;
        static void Main(string[] args)
        {
            TcpServer Server = new TcpServer(PORT);
            Console.WriteLine("im Server");
            Server.Start();

            Console.ReadLine();
        }
    }
}
