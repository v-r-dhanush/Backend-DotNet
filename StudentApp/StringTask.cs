using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentApp
{
    internal class StringTask
    {
        public void arrstr()
        {
            int count = 0;
            string[] fruits = { "Banana", "Apple", "Orange", "Grapes" };
            Console.WriteLine("enter the fruit to replace");
            string change = Console.ReadLine();
            Console.WriteLine("Enter the fruit to add ");
            string changenew = Console.ReadLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].Equals(change, StringComparison.OrdinalIgnoreCase))
                {
                    fruits[i] = fruits[i].Replace(change, changenew);
                    break;
                }
                else
                {
                    count ++;

                }
            }
            if (count == 4)
            {
                Console.WriteLine($"The Enter Value {change} is not avalaible");

            }
            else
            {
                Console.WriteLine("Array After Replace :");
                for (int i = 0; i < fruits.Length; i++)
                {
                    Console.WriteLine(fruits[i]);
                }
            }
        }

        public void findWord()
        {
            string str1 = "She sells sea shells on the sea shore";
            string[] str2 = str1.Split(" ");
            Console.WriteLine($"There are {str2.Length} words in {str1}");
            char chf = 's';
            int chcount = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == chf)
                {
                    chcount++;
                }
            }
            Console.WriteLine($"There are {chcount} in {str1}");
        }
        
    }
}
