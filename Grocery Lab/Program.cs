using System;
using System.Collections.Generic;

namespace Grocery_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            bool restart = true;
            string choice;

            Dictionary<string, double> groceries = new Dictionary<string, double>
            {
                {"apple", 0.99},
                {"banana", 0.59},
                {"cauliflower", 1.59},
                {"dragonfruit", 2.19},
                {"elderberry", 1.79},
                {"figs", 2.09},
                {"grapefruit", 1.99},
                {"honeydew", 3.49}
            };

            List<double> prices = new List<double>();
            List<string> items = new List<string>();

            Console.WriteLine("Welcome to SeanMart, please select an item from the menu");
            Console.WriteLine("Item         Cost");
            Console.WriteLine("=================");

            while (keepGoing)
            {


                while (true)
                {
                    foreach (KeyValuePair<string, double> kvp in groceries)
                    {
                        Console.WriteLine($"{kvp.Key}   {kvp.Value}");
                    }
                    choice = Console.ReadLine();
                    double itemCheck;

                    if (groceries.TryGetValue(choice, out itemCheck))
                    {
                        Console.WriteLine($"You have selected {choice}, the price is {itemCheck}");
                        items.Add(choice);
                        prices.Add(groceries[choice]);

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, please select an item from the menu");
                        break;
                    }


                }











                while (true)
                {
                    Console.WriteLine("Would you like to order something else? y/n");
                    string ugh = Console.ReadLine();
                    if (ugh == "n")
                    {
                        keepGoing = false;
                        break;
                    }
                    else if (ugh == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please select y/n");
                    }
                }
            }



            Console.WriteLine("Thanks for your order");
            Console.WriteLine("Heres what you got");

            for (int i = 0; i < items.Count; i++)

            {
                Console.WriteLine($"{items[i]}   {prices[i]}");
            }
            



        }




    }
}
