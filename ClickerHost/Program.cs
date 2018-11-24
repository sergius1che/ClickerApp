using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var server = new Server(int.Parse(args[0])))
                {
                    server.Start();
                }
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText("error.log", e.ToString());
                Console.WriteLine("Error hapen! See: error.log");
            }
        }
    }
}
