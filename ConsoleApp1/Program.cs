using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void a()
        {
            while(true)
            {
                Console.WriteLine("A");
            }
        }
        static void b()
        {
            while(true)
            {
                Console.WriteLine("B");
            }
        }
        static void Main(string[] args)
        {

            Thread aa = new Thread(a);
            Thread.Sleep(8);
            Thread bb = new Thread(b);
            Thread.Sleep(8);
            aa.Start();
            bb.Start();


            FileStream readFile = new FileStream(@"D: \Users\6001697\Downloads\资料\测试.zip",FileMode.Open ,FileAccess.Read );

            readFile.ReadByte();

            FileStream writeFile = new FileStream(@"D: \Users\6001697\Downloads\资料\侧视.zip", FileMode.Create, FileAccess.Write);

            //writeFile.WriteByte();

            int nextBYTE = -1;
            while((nextBYTE=readFile.ReadByte()) !=  -1)
            {
                writeFile.WriteByte((byte)nextBYTE);
            }

            writeFile.Close();
            readFile.Close();
        }
    }
}
