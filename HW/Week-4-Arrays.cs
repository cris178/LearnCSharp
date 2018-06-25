using System;

namespace Week4ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {

            string selection = "blank";
            Console.WriteLine("Welcome to my Shop!");

            Console.WriteLine("Here are my items.");

            string[] items = new string[] {"Apple", "Potion", "Pokeball", "Revive" };

            foreach (string i in items) {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\nWhat Item do you want to buy?");
            selection = Console.ReadLine();

            foreach (string i in items)
            {
                if (selection == i) {
                    Console.WriteLine("You selected " +  i);
                }
            }
            Console.WriteLine("Goodbye!");





            //Pause The Program
            Console.ReadLine();
        }
    }
}

