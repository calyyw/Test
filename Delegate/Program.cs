using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Delegate
{
    class Program
    {
        static FileStream fs;
        static StreamWriter sw;

        // 委托声明
        public delegate void printString(string s);

        public delegate int printName(string s);

        //public static string myName(string name)
        //{
        //    if (name.Equals("yyw"))
        //        return "0";
        //    else
        //        return "1";
 
        //}

        public static int myName(string name)
        {
            if (name.Equals("yyw"))
                return 0;
            else
                return 1;
        }
        

        // 该方法打印到控制台
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }
        // 该方法打印到文件
        public static void WriteToFile(string s)
        {
            fs = new FileStream("c:\\message.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // 该方法把委托作为参数，并使用它调用方法
        public static void sendString(printString ps)
        {
            ps("Hello World");
        }
        static void Main(string[] args)
        {
            printName pm = new printName(myName);

            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            printString ps3 = WriteToFile;

            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();


        }
    }
}
