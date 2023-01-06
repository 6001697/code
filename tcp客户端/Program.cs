// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Net.Sockets;
using System.Text;

Socket tcpclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

IPAddress ipadder = new IPAddress(new byte[] { 192, 168, 1, 12 });

IPEndPoint ipandpoint = new IPEndPoint(ipadder, 10086);

tcpclient.Connect(ipandpoint);

Console.WriteLine("连接上服务器了");

//发送消息
string messages = "我来了";
tcpclient.Send(Encoding.UTF8.GetBytes(messages));

//接受消息
byte[] data = new byte[1024];
int lenger = tcpclient.Receive(data);

Console.WriteLine("收到服务端的消息：" + Encoding.UTF8.GetString(data, 0, lenger));

tcpclient.Close();

