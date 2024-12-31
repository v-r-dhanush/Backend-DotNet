using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentApp
{
    internal class Faculty : Student
    {
      
        public string Facultyname { get; set; }
       

        public void showdetails()
        {
            if (Facultyname != "")
            {
                Console.WriteLine("Name of Faculty : " + Facultyname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender: " + gender);
            }
        }
    }
}
