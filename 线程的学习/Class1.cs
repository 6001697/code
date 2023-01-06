using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线程的学习
{
    internal class Class1
    {
        public string URL { get; private set; }
        public string Message { get; private set; }

        public Class1(string uRL, string message)
        {
            URL = uRL;
            Message = message;
        }
        public void Download()
        {
            Console.WriteLine("从" + URL + "下载中。。。。。。");
        }
    }
}
