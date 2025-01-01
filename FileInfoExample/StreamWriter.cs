using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfoExample
{
    class StreamWriters
    {
        public void streamwrite()
        {
            //delete the file, if it already exists
            FileInfo f = new FileInfo(@"D:\Dhanush\Backend\Dotnet\Sample.txt");
            if (f.Exists == true)
                f.Delete();
            //create the file
            FileStream fs = new FileStream(@"D:\Dhanush\Backend\Dotnet\Sample1.txt",
           FileMode.Create, FileAccess.Write);
            //write data to the file
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hai");
            sw.WriteLine("Hello");
            sw.WriteLine("How are you");
            //close the file
            sw.Close();
            Console.WriteLine("Written");

        }
    }
}
