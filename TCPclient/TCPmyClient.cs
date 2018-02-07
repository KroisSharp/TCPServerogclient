using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPclient
{
    class TCPmyClient
    {
        private readonly int PORT;

        //ctor husk at lav navnet om
        public TCPmyClient(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            using (TcpClient client = new TcpClient("localhost", PORT))
            using (NetworkStream stream = client.GetStream())
            using (StreamReader reader = new StreamReader(stream))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.AutoFlush = true;
                int antal = 1;
                //kode her
                while (true)
                {
                    string _sendMe = "hej fra client";

                    writer.WriteLine(_sendMe + antal);
                    antal++;
                    Thread.Sleep(1000);
                }


            }
        }

    }
}
