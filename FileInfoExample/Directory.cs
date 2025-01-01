using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfoEg
{
    class Directory1
    {
        public void directory()
        {
            if (Directory.Exists(@"D:\Dhanush\Backend\Dotnet\Sample\folder1") == true)
            {
                Directory.Delete(@"D:\Dhanush\Backend\Dotnet\Sample\folder1", true);
            }
            if (Directory.Exists(@"D:\Dhanush\Backend\Dotnet\Sample\folder2") == true)
            {
                Directory.Delete(@"D:\Dhanush\Backend\Dotnet\Sample\folder2", true);
            }
            Directory.CreateDirectory(@"D:\Dhanush\Backend\Dotnet\Sample\folder1");
            Console.WriteLine("folder1 created");
            Console.WriteLine("folder1 exists: " + Directory.Exists(@"D:\Dhanush\Backend\Dotnet\Sample\folder1"));
            //Output: True
            Directory.Delete(@"D:\Dhanush\Backend\Dotnet\Sample\folder1");
            Console.WriteLine("folder1 deleted");
            Console.WriteLine("folder1 exists: " + Directory.Exists(@"D:\Dhanush\Backend\Dotnet\Sample\folder1"));
            Directory.CreateDirectory(@"D:\Dhanush\Backend\Dotnet\Sample\folder1");
            Console.WriteLine("folder1 created");
            Directory.Move(@"D:\Dhanush\Backend\Dotnet\Sample\folder1", @"D:\Dhanush\Backend\Dotnet\Sample\folder2");
            Console.WriteLine("folder1 moved as folder2");
        }

    }
}
