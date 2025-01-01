using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfoExample
{
    class StreamReaders
    {
        public void streamrd()
        {
            //check the file exists or not
            FileInfo f = new FileInfo(@"D:\Dhanush\Backend\Dotnet\Sample1.txt");
            if (f.Exists == true)
            {
                //open the file
                FileStream fs = new FileStream(@"D:\Dhanush\Backend\Dotnet\Sample1.txt",
FileMode.Open, FileAccess.Read);
                //read the file
                StreamReader sr = new StreamReader(fs);
                string s = sr.ReadToEnd();
                //close the file
                sr.Close();
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }
    }
}
