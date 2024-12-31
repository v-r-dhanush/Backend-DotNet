using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studentApp
{
    class Student : IPerson,IAddress,IContact
    {
        public int rollno { get; set; }
        public string pname { get; set; }
        public char gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zipcode { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }


        public string showContact()
        {
            return $"Phone: {Phone },Email:{Email}";
        }

        public string getAddress()
        {
            return $"Address is City: {City },State:{State },Pincode:{Zipcode}";
        }
        //public string sname { get; set; }
        //public char gender { get; set; }

        public void showdetails()
        {
            if (rollno > 0)
            {
                Console.WriteLine("Roll No: " + rollno);
            }
            if (pname != "")
            {
                Console.WriteLine("Name of student: " + pname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender: " + gender);
            }
        }

        public static int id = 1;
        public static int incrementId()
        {
            return id++;
        }

        public void displayDetails(int rollno=0, string sname="", char gender=' ')
        {
            if (rollno > 0)
            {
                Console.WriteLine("Roll No: " + rollno);
            }
            if (sname != "")
            {
                Console.WriteLine("Name of student: " + sname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender: " + gender);
            }
        }


    }
}
