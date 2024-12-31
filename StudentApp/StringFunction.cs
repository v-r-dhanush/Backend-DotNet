using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentApp
{
    internal class StringFunction
    {
        string fullname = "dhanush venkadachalam ravi ";
        string greeting = "have a good day";
        string city = "chennai";
        string city1 = "Perambalur";
        string city2 = "Aranari";


        public void stringMethods()
        {
            Console.WriteLine("Actual string: " + fullname);
            Console.WriteLine("Actual string: " + fullname.Trim());
            Console.WriteLine(fullname.ToLower());
            Console.WriteLine(fullname.ToUpper());
            Console.WriteLine(fullname[0]);
            Console.WriteLine(fullname.Substring(1,3));
            Console.WriteLine(fullname.Remove(1,3));
            Console.WriteLine(fullname.StartsWith("dhanush"));
            Console.WriteLine(fullname.EndsWith("dhanush"));
            Console.WriteLine(fullname.Contains("ravi"));
            Console.WriteLine("Equal method: " + city1.Equals(city2,StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(fullname.Equals(greeting));
            Console.WriteLine(fullname.IndexOf(" "));
            Console.WriteLine(fullname.LastIndexOf(" "));
            Console.WriteLine(string.Format("have a good day {0}",fullname));
            char[] chrs = city.ToCharArray();
            foreach(char c in chrs) Console.WriteLine(c);
            string[] nameArr = fullname.Split(" ");
            foreach (string s in nameArr) Console.WriteLine(s);
            Console.WriteLine(string.Join(" ",nameArr));
        }

        public void task()
        {
            Console.WriteLine("Enter the string");
            string name = Console.ReadLine();

     
            string titleCased = string.Join(" ", name.Split(' ').Select(word =>
            char.ToUpper(word[0]) + word.Substring(1).ToLower()));

            Console.WriteLine("Title Cased: " + titleCased);

            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("enter the string");
            string place = Console.ReadLine();

            string city = "";

            for (int i = place.Length - 1; i >= 0; i--)
            {
                city += place[i];
            }
            Console.WriteLine("Reverse string:" + city);   


        }


    }
}

