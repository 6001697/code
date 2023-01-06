using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime befor = DateTime.Now; 
            FileStream readFile = new FileStream(@"D: \Users\6001697\Downloads\资料\测试.zip", FileMode.Open, FileAccess.Read);

            readFile.ReadByte();

            FileStream writeFile = new FileStream(@"D: \Users\6001697\Downloads\资料\侧视.zip", FileMode.Create, FileAccess.Write);

            //writeFile.WriteByte();

            int nextBYTE = -1;
            while ((nextBYTE = readFile.ReadByte()) != -1)
            {
                writeFile.WriteByte((byte)nextBYTE);
            }

            writeFile.Close();
            readFile.Close();

            DateTime after = DateTime.Now;
            TimeSpan ts = after.Subtract(befor);
            Console.WriteLine(ts.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
