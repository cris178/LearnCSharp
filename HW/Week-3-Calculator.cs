sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week3HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables needed
            int numb1;
            int numb2;
            int numb3;
            string finish = "";



            //Title Message appearing only once
            Console.WriteLine("Welcome to the Calculator Program");


            //While Loop placed before actual implementation
            while (finish != "Exit" && finish != "exit") {

                //Prompt user for first number and put in our integer variable
                Console.WriteLine("Please Enter Your First Value.");
                numb1 = Int32.Parse(Console.ReadLine());

                //Prompt user for second number and put in our second interget variable
                Console.WriteLine("Please Enter Your Second Value.");
                numb2 = Int32.Parse(Console.ReadLine());

                //Add both variables together that contain our numbers and put them in a third variable
                numb3 = numb1 + numb2;

                //Display what we did and show the results
                Console.Write(numb1);
                Console.Write(" + ");
                Console.Write(numb2);
                Console.WriteLine(" = ");
                Console.WriteLine(numb3);

                //Prompt the user if he wants to exit
                Console.WriteLine("To Finish type Exit");
                finish = Console.ReadLine();
            }

            //Goodbye Message will only display when the While Loop is finished.
            Console.WriteLine("Goodbye!");

            //Pause the machine so that we can display our program.
            Console.ReadLine();

        }
    }
}

