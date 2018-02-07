using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPEchoServer
{
    class TcpServer
    {

        //de arbejder på PORT 6789

        private readonly int PORT;

        //husk at ændre navn
        public TcpServer(int port)
        {
            this.PORT = port;
        }
        public void Start()
        {

            TcpListener listener = TcpListener.Create(PORT);
            listener.Start();

            while (true)
            {
                {

                    TcpClient client = listener.AcceptTcpClient();
                    Task.Run(() => DoClient(client));

                }
            }

        }

        private static void DoClient(TcpClient client)
        {
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.AutoFlush = true;

                //code her
                while (true)
                {
                string _strModtag = sr.ReadLine();

                Console.WriteLine(_strModtag);
                    
                }
                

            }
        }

    }
}
