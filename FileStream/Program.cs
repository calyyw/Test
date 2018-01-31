using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FileStream F = new FileStream("test.dat",
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;

            for (int i = 0; i <= 30; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
            */

            #region 文件属性
            /*
            string filePath="C:\\Users\\YYW\\Desktop\\亦庄综治\\领导决策APP页面及功能20171130.docx";

            //use File class
            Console.WriteLine(File.GetAttributes(filePath));
            File.SetAttributes(filePath, FileAttributes.Hidden | FileAttributes.ReadOnly);
            Console.WriteLine(File.GetAttributes(filePath));

            //user FilInfo class
            FileInfo fi = new FileInfo(filePath);
            Console.WriteLine(fi.Attributes.ToString());
            fi.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly; //隐藏与只读
            Console.WriteLine(fi.Attributes.ToString());

            //只读与系统属性，删除时会提示拒绝访问
            fi.Attributes = FileAttributes.Archive;
            Console.WriteLine(fi.Attributes.ToString());
            Console.ReadKey();
            */
            //string dirPath = "C:\\Users\\YYW\\Desktop\\亦庄综治";
            //DirectoryInfo dir = new DirectoryInfo(dirPath);
            //Console.WriteLine(dir.Extension);
            #endregion

            #region 文件和文件夹路径
            string dirPath = @"D:\TestDir";
            string filePath = @"D:\TestDir\TestFile.txt";
            Console.WriteLine("<<<<<<<<<<<{0}>>>>>>>>>>", "文件路径");
            //获得当前路径
            Console.WriteLine(Environment.CurrentDirectory);
            //文件或文件夹所在目录
            Console.WriteLine(Path.GetDirectoryName(filePath));     //D:\TestDir
            Console.WriteLine(Path.GetDirectoryName(dirPath));      //D:\
            //文件扩展名
            Console.WriteLine(Path.GetExtension(filePath));         //.txt
            //文件名
            Console.WriteLine(Path.GetFileName(filePath));          //TestFile.txt
            Console.WriteLine(Path.GetFileName(dirPath));           //TestDir
            Console.WriteLine(Path.GetFileNameWithoutExtension(filePath)); //TestFile
            //绝对路径
            Console.WriteLine(Path.GetFullPath(filePath));          //D:\TestDir\TestFile.txt
            Console.WriteLine(Path.GetFullPath(dirPath));           //D:\TestDir  
            //更改扩展名
            Console.WriteLine(Path.ChangeExtension(filePath, ".jpg"));//D:\TestDir\TestFile.jpg
            //Console.WriteLine(Path.ChangeExtension(dirPath, ".jpg"));
            //根目录
            Console.WriteLine(Path.GetPathRoot(dirPath));           //D:\     
 

            //生成路径
            //Console.WriteLine(Path.Combine(new string[] { @"D:\", "BaseDir", "SubDir", "TestFile.txt" })); //D:\BaseDir\SubDir\TestFile.txt
            Console.WriteLine(Path.Combine(Path.Combine(@"D:\", "BaseDir\\"), Path.Combine("SubDir\\", "TestFile.txt")));

            //Console.WriteLine("合并路径开始");

            //Console.WriteLine(@"D:\");
            ////Console.WriteLine("D:\\");
            //Console.WriteLine("BaseDir\\");
            //Console.WriteLine("SubDir");
            //Console.WriteLine("TestFile.txt");

            //Console.WriteLine(Path.Combine(@"D:\", "BaseDir\\"));
            //Console.WriteLine(Path.Combine(@"D:\\", "BaseDir"));
            //Console.WriteLine(Path.Combine(@"D:", "BaseDir"));
            //Console.WriteLine(Path.Combine("SubDir\\", "TestFile.txt"));
            //Console.WriteLine(Path.Combine("SubDir", "TestFile.txt"));

            //Console.WriteLine("合并路径结束");
            //Path.Combine( @"D:\", "BaseDir");
            //Path.Combine("SubDir", "TestFile.txt");

            //生成随即文件夹名或文件名
            Console.WriteLine("随机文件（夹）名：" + Path.GetRandomFileName());

            //创建磁盘上唯一命名的零字节的临时文件并返回该文件的完整路径
            Console.WriteLine("临时文件名：" + Path.GetTempFileName());

            //返回当前系统的临时文件夹的路径
            Console.WriteLine("临时目录名：" + Path.GetTempPath());

            //文件名中无效字符
            Console.WriteLine("文件名中无效字符：");
            Console.WriteLine(Path.GetInvalidFileNameChars());

            //路径中无效字符
            Console.WriteLine("路径中无效字符：");
            Console.WriteLine(Path.GetInvalidPathChars());
            Console.ReadKey();
            #endregion

        }
    }
}
