using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程的学习
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 downloadtool = new Class1("hasjhdjhsajd", "4542122");
            Thread t = new Thread(downloadtool.Download);
            t.Start();
            Console.ReadLine();
        }
    }
}
