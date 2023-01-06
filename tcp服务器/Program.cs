using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace tcp服务器
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpserwer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipadder = new IPAddress(new byte[] { 192, 168, 1, 12 });

            IPEndPoint ipandpoint = new IPEndPoint(ipadder, 10086);

            tcpserwer.Bind(ipandpoint);
            tcpserwer.Listen(100);

            Console.WriteLine("开始接客了。。。。。");

            Socket clicu =tcpserwer.Accept();

            Console.WriteLine("一个客户端连接成功");
            Console.ReadLine();

        }
    }
}
