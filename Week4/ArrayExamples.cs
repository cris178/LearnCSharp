using System;

namespace Week4ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //An array named numers is created. It does not have any values and it does not have a size.
            int[] numbers;

            //Assign the arry numbers with the values 5, 2, 1, 3, and 8. The size of the array is 5.
            numbers = new int[] {5, 2, 1, 3, 8};


            Console.WriteLine("Numbers Array");
            //Display the value in the array safe way
            foreach (int i in numbers) {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\nThe arrays in C# have built in functionality that allow you to see the size of the array.");
            Console.WriteLine("The size of the numbers array is: " + numbers.Length + "\n");
            //  \n allows you to add a paragraph break. n stands for newline. You can use \n to make a new line or just an empty Console.WritLine()


            //Create and initialize a new array of strings. The array is size 4.
            string[] items = new string[] {"Potion", "Revive Elixer", "Sword", "Map" };

            Console.WriteLine("Items Array");
            //Display the value in the array not safe way but the way most other languages do/did it.
            for (int i = 0; i < items.Length; i++){
                Console.Write(items[i] + ", ");
            }
            Console.WriteLine("\nThe size of the items array is: " + items.Length);

            //Pause The Program
            Console.ReadLine();
        }
    }
}

