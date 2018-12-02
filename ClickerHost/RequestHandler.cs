using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClickerHost
{
    public class RequestHandler
    {
        private TcpClient _tcpClient;

        public RequestHandler(TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
        }

        public void Run()
        {
            Console.WriteLine("Client recieve");

            var stream = _tcpClient.GetStream();

            string httpRequest = GetRequest(stream);

            if (!string.IsNullOrEmpty(httpRequest))
            {
                Console.WriteLine(httpRequest);

                int? keycode = GetKeyCode(httpRequest);
                string response = "error";

                if (keycode.HasValue)
                {
                    var key = (Keys)keycode.Value;
                    KeyboardSend.KeyDown(key);
                    KeyboardSend.KeyUp(key);
                    Console.WriteLine($"Success send key: {key.ToString()} ({(int)key})");
                    response = "success";
                }

                string httpResponse = "HTTP/1.1 200 OK\nAccess-Control-Allow-Origin:*\nContent-type: text/html\nContent-Length:" + response.Length.ToString() + "\n\n" + response;
                byte[] buffer = Encoding.ASCII.GetBytes(httpResponse);
                stream.Write(buffer, 0, buffer.Length);
                Console.WriteLine("Client send: " + response);
                Console.WriteLine("===============================================================================");
                Console.WriteLine();
            }
            _tcpClient.Close();
        }

        private int? GetKeyCode(string httpRequest)
        {
            if (string.IsNullOrEmpty(httpRequest))
                return null;

            var getIndex = httpRequest.IndexOf("GET");

            if (getIndex == -1)
                return null;

            var varName = "/?key=";
            var varNameIndex = httpRequest.IndexOf(varName, getIndex);

            if (varNameIndex == -1)
                return null;

            var start = varNameIndex + varName.Length;
            var length = httpRequest.IndexOf(' ', start) - start;

            var key = httpRequest.Substring(start, length);

            if (int.TryParse(key, out int keyCode))
            {
                Console.WriteLine("KeyCode send: " + keyCode);
                return keyCode;
            }

            return null;
        }

        private string GetRequest(NetworkStream stream)
        {
            string httpRequest = string.Empty;
            byte[] Buffer = new byte[1024];
            int Count;
            while ((Count = stream.Read(Buffer, 0, Buffer.Length)) > 0)
            {
                httpRequest += Encoding.ASCII.GetString(Buffer, 0, Count);
                if (httpRequest.IndexOf("\r\n\r\n") >= 0 || httpRequest.Length > 4096)
                {
                    break;
                }
            }

            return httpRequest;
        }
    }
}
