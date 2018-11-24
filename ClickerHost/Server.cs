using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClickerHost
{
    public class Server : IDisposable
    {
        TcpListener Listener;
        
        public Server(int Port)
        {
            Listener = new TcpListener(IPAddress.Any, Port);
        }

        public void Start()
        {
            Listener.Start();
            TaskFactory taskFactory = new TaskFactory();

            while (true)
            {
                var client = Listener.AcceptTcpClient();

                taskFactory.StartNew(new RequestHandler(client).Run);
            }
        }
        
        public void Dispose()
        {
            if (Listener != null)
            {
                Listener.Stop();
            }
        }
    }
}
