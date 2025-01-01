using FileInfoExample;
using System;
using System.IO;
namespace FileInfoEg
{
    class Program
    {
        static void Main()
        {
            //FileInfo f;
            //f = new FileInfo(@"D:\Dhanush\Backend\Dotnet\Sample.txt");
            //Console.WriteLine("Exists: " +  f.Exists);

            //if(f.Exists)
            //{
            //    Console.WriteLine("Full name : " + f.FullName);
            //    Console.WriteLine("Name : " + f.Name);
            //    Console.WriteLine("Directory name : " + f.DirectoryName);
            //    Console.WriteLine("Extension : " + f.Extension);
            //    Console.WriteLine("Creation date and time : " + f.CreationTime);
            //    Console.WriteLine("Modification date and time : " + f.LastWriteTime);
            //    Console.WriteLine("Access date and time : " + f.LastAccessTime);
            //    Console.WriteLine("Length : " + f.Length + " bytes");
            //}

            //DirectoryInfoo diri = new DirectoryInfoo();
            //diri.directoryinfo();



            //Directory1 dir = new Directory1();
            //dir.directory();


            //Filee fil = new Filee();
            //fil.file();


            //StreamWriters sw = new StreamWriters();
            //sw.streamwrite();


            StreamReaders sr = new StreamReaders();
            sr.streamrd();

            Console.ReadKey();
        }

        
    }
}
