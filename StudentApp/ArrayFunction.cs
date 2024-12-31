using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace studentApp
{
    internal class ArrayFunction
    {
        public void showArrayFunction()
        {
            int[] numbers = { 10, 201, 0, 4, 51 };
            int[] newNumbers = new int[5];

            //Console.WriteLine(Array.IndexOf(numbers,4));
            //Console.WriteLine(Array.BinarySearch(numbers,51));
            //numbers.CopyTo(newNumbers, 0);
            //Array.Resize(ref newNumbers, 7);
            //newNumbers[5] = 15;
            //newNumbers[6] = 13;
            //Array.Clear(newNumbers, 3, 2);
            ////Array Sort(numbers)
            ////Array.Reverse(numbers);
            //Console.WriteLine("****************************************");
            //foreach(int i in newNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("enter the number");
            int search = Convert.ToInt32(Console.ReadLine());
            bool Result = false;
            for (int num = 0; num < numbers.Length; num++)
            {
                if (numbers[num] == search)
                {
                    Result = true;
                    break;
                }
            }
            if (Result)
            {
                Console.WriteLine($"Yes {search} is present in the Array");
            }

            else
            {
                Console.WriteLine($"NO {search} is not present in the Array");
            }
        }


        public void showStringFunction()
        {
            string[] fruits = { "apple", "orange", "banana" };

            Console.WriteLine("enter the fruit want to search:");
            string search = Console.ReadLine();
            int res = -1;

            for(int i=0;i<fruits.Length;i++)
            {
                if (fruits[i].Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    res = i;
                    break;
                }
            }
            if(res>=0)
            {
                Console.WriteLine($"YES {search} Its present in the array");
            }
            else
            {
                Console.WriteLine($"No {search} Its not present in the array");
            }

        }



        public void operationFruit()
        {
            Console.WriteLine("1.Display fruits");
            Console.WriteLine("2.Select fruits");

            Console.WriteLine("Enter the Option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                default:
                    Console.WriteLine("You Entered Wrong Option");
                    break;
                case 1:
                    showArrayFunction();
                    break;
                case 2:
                    showStringFunction();
                    break;
            }
        }
    }
}


