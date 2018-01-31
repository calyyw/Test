using System;
using System.IO;

namespace WindowsFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个 DirectoryInfo 对象
            DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");
            //DirectoryInfo mydir = new DirectoryInfo("c:/Windows");

            Console.WriteLine("Dir Exist: {0} Extention: {1}", mydir.Exists, mydir.Extension);

            // 获取目录中的文件以及它们的名称和大小
            FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
            }
            Console.ReadKey();
        }
    }
}