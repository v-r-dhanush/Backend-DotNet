using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studentApp
{
    internal class ListMethods
    {
        Commonmethod cm = new Commonmethod();
        public void showListMethods()
        {
            List<int> numbers = new List<int>() { 2, 40, 10, 15, 100, 74 };
            List<int> newNumbers = new List<int>() { 5, 2, 3 };


            numbers.Add(11);
            numbers.Insert(2, 55);
            //numbers.InsertRange(3,);
            numbers.AddRange(newNumbers);
            numbers.Sort();
            numbers.Reverse();
            numbers.Remove(40);
            numbers.Remove(2);

            for(int i=0; i<numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        List<string> fruits = new List<string>() { "apple", "orange", "banana" };
        public void showListTask()
        {
            Console.WriteLine("-----------------Menu-------------------");
            Console.WriteLine("1.Display Fruits");
            Console.WriteLine("2.Add Fruits");
            Console.WriteLine("3.Update Fruits");
            Console.WriteLine("4.Delete Fruits");
            Console.WriteLine("5.Exit");
            Console.Write("Enter the option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    displayfruit();
                    showListTask();
                    break;
                case 2:
                    addfruit();
                    displayfruit();
                    showListTask();
                    break;
                case 3:
                    updatefruit();
                    displayfruit();
                    showListTask();
                    break;
                case 4:
                    deletefruit();
                    displayfruit();
                    showListTask();
                    break;
                case 5:
                    Console.WriteLine("Thank you!!");
                    break;
            }
        }

        //public void titlecase()
        //{
        //    string titleCased = string.Join(" ", name.Split(' ').Select(word =>
        //    char.ToUpper(word[0]) + word.Substring(1).ToLower()));

        //}

        public void displayfruit()
        {
            //string titleCased = string.Join(" ", fruits.Split(' ').Select(word =>
            //char.ToUpper(word[0]) + word.Substring(1).ToLower()));
            for(int i=0;i<fruits.Count;i++)
            {
                string title = fruits[i];
                string title1 = title[0].ToString().ToUpper()+title.Substring(1).ToLower();
                fruits[i]=title1;
            }
            for (int i=0;i<fruits.Count;i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
        public void addfruit()
        {
            string add = cm.commonUI("Enter the fruit to add: ");

            fruits.Add(add);

            Console.WriteLine("after add the fruit :");
            
        }

        public void updatefruit()
        {
            
            string update = cm.commonUI("Enter the fruit want to update: ");
            int count = 0;
            string newupdate = cm.commonUI("Enter the fruit to update: ");

            bool fruitFound = true;
            bool newNameExists = false;

            

            if (fruitFound)
            {
                Console.WriteLine($"The fruit '{update}' has been updated to '{newupdate}'.");
                if (fruits.Any(f => f.Equals(newupdate, StringComparison.OrdinalIgnoreCase)))
                {
                    newNameExists = true;
                }

                for (int i = 0; i < fruits.Count; i++)
                {
                    if (fruits[i].Equals(update, StringComparison.OrdinalIgnoreCase))
                    {
                        if (!newNameExists)
                        {
                            fruits[i] = newupdate;
                            fruitFound = true;
                        }
                        else
                        {
                            Console.WriteLine($"The fruit '{newupdate}' already exists in the list. Please choose a different name.");
                            return;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"The fruit '{update}' was not found in the list.");
            }

           
            Console.WriteLine("Updated fruit list:");
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}
        }


        public void deletefruit()
        {
            string delete = cm.commonUI("Enter the fruit need to delete: ");
            int count = 0;

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Equals(delete, StringComparison.OrdinalIgnoreCase))
                {

                    fruits.RemoveAt(i);
                }
                else
                {
                    count += 1;
                }
                if(count == fruits.Count)
                {
                    Console.WriteLine($"the {delete} has been deleted");
                }
            }
            Console.WriteLine("After the delete");
        }

    }
}
