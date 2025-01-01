using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfoExample
{
    class Filee
    {
        public void file()
        {
            if (Directory.Exists(@"D:\Dhanush\Backend\Dotnet\Sample\folder1") == true)
            {
                Directory.Delete(@"D:\Dhanush\Backend\Dotnet\Sample\folder1", true);
            }
            Directory.CreateDirectory(@"D:\Dhanush\Backend\Dotnet\Sample\folder1");
            Console.WriteLine("Folder created");
            File.Create(@"D:\Dhanush\Backend\Dotnet\Sample\folder1\sample1.txt").Close();
            Console.WriteLine("File created");
            //File.Create(@"D:\Dhanush\Backend\Dotnet\Sample\folder1\sample2.txt").Close();
            //Console.WriteLine("File created");
            File.Copy(@"D:\Dhanush\Backend\Dotnet\Sample\folder1\sample1.txt", @"D:\Dhanush\Backend\Dotnet\Sample\folder1\sample2.txt");
            Console.WriteLine("File created");
            File.Move(@"D:\Dhanush\Backend\Dotnet\Sample\folder1\sample2.txt", @"D:\Dhanush\Backend\Dotnet\Sample\folder1\sample3.txt");
            Console.WriteLine("File moved");
            Console.WriteLine("File exists: " + File.Exists(@"D:\Dhanush\Backend\Dotnet\Sample\folder1\sample3.txt"));
        }
    }
}
