using System;
using System.IO;
namespace FileInfoEg
{
    class DirectoryInfoo
    {
        public void directoryinfo()
        {
            DirectoryInfo d;
            d = new DirectoryInfo(@"D:\Dhanush\Backend\Dotnet\Sample");
            Console.WriteLine("Exists: " + d.Exists);
            if (d.Exists)
            {
                Console.WriteLine("Full name: " + d.FullName);
                Console.WriteLine("Name: " + d.Name);
                Console.WriteLine("Directory name: " + d.Parent.Name);
                Console.WriteLine("Creation date and time: " + d.CreationTime);
                Console.WriteLine("Modification date and time: " + d.LastWriteTime);
                Console.WriteLine("Access date and time: " + d.LastAccessTime);
                Console.WriteLine("\nFiles:");
                FileInfo[] files = d.GetFiles();
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i].FullName);
                }

                Console.WriteLine("\nSub directories:");
                DirectoryInfo[] directories = d.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {
                    Console.WriteLine(directories[i].FullName);
                }
            }
        }
    }
}
