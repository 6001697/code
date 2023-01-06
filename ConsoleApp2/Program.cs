using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        delegate double Doubleopdelgatr(double x);
        static void Main(string[] args)
        {
            Doubleopdelgatr[] arry = { mathOP.MultipalyByTwo, mathOP.Squary };
            foreach (Doubleopdelgatr temp in  arry)
            {
                Console.WriteLine("结果是：" + temp(4));
            }
            Console.ReadLine();
        }
    }
}
