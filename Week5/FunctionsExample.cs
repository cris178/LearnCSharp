using System;

namespace Week5FunctionsExample
{
    class Program
    {

        //A void function returns nothing back to our main code
        static void DisplayTitle() {
            Console.WriteLine("Knights\n\n");
            Console.WriteLine("Enter any key to continue.");
        }

        //put the type of value you want to return after the static
        static string getName() {
            //Example shown below that this variable named name is not the same as the one in our main code
            string name = "somename";
            Console.WriteLine("Enter You Name");
            name = Console.ReadLine();
            return name;
        }

        //put the type of value you want to return after the static
        static int getAge()
        {
            int age = 0;
            Console.WriteLine("Please Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        //This function gets the choice of pokemon the user picks and returns its to main
        //Not only that but it also has the variable choice passed into the function
        static string getChoice(string choice) {
            string pick = "no";
            string newChoice = choice;
            Console.WriteLine("You selected " + newChoice + "is this correct?");
            Console.WriteLine("Yes/No?");
            pick = Console.ReadLine();
            while(pick == "no" || pick == "No")
            {
                Console.WriteLine("Pick your companion Charmander, Bulbasaur, or Squirtle");
                newChoice = Console.ReadLine();
                Console.WriteLine("You selected " + newChoice + " is this correct?");
                Console.WriteLine("Yes/No?");
                pick = Console.ReadLine();
            }
            
            return newChoice;
        }


        //This is where the program actually starts at
        static void Main(string[] args)
        {
            //We call the function "FirstFunction" below which jumps from line 19 to line 9 of the code
            //When it finishes the instructions in the function it returns to the next instruction after the DisplayTitle() call.
            DisplayTitle();
            Console.ReadKey();

            //Variables if created inside variables won't work outside the function.
            //It's not recommended to make variables that are "Global" and work every single place
            //But at this stage we will make a few.

            string name = "blank";
            int age = 0;

            name = getName();

            while (age <= 0 || age >= 100) {
                age = getAge();
            }

            Console.WriteLine("Your name is " + name + " and your are " + age + " years old.");
            Console.WriteLine("...");

            //Your Bag of Pokemon is an array of size 6 that will only hold 6 strings
            string[] pokemon = new string[6];

            Console.WriteLine("Pick your companion Charmander, Bulbasaur, or Squirtle");
            string choice = Console.ReadLine();
            pokemon[0] = getChoice(choice);

            //The newChoice variable that was in the function is returned and put inside the first spot in our array.
            //Display the first value in the array below to see if it worked.

            Console.WriteLine( "Your first pokemon is " + pokemon[0] + "!" );

            Console.ReadKey();




        }
    }
}

