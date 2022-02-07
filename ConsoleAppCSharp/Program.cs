using System;

namespace ConsoleAppCSharp
{
    class Program
    {
        static void Main(string[] args)
        {//Code block of Main method

            Console.WriteLine("Hello World!");

            //string userName = Console.ReadLine();
            string userName = AskUserFor("your name");

            Console.WriteLine("Hello " + userName);

            //int userAge = Convert.ToInt32( AskUserFor("your age") );
            int userAge = AskUserForNumber("your age");

            if(userAge > 17)
            {
                Console.WriteLine("Do you want a Beer?");
            }
            else
            {
                Console.WriteLine("Do you want a Soda?");
            }

            bool keepLooping = true;

            while(keepLooping)
            {
                Console.Clear();

                PrintMenu();

                int userPick = AskUserForNumber("menu selection");

                switch (userPick)
                {
                    case 1:
                        for(int i = 3; i > 0; i--)
                        {
                            Console.WriteLine("Counting down: " + i);
                        }
                        break;
                    case 2:
                        CodeLove();
                        break;
                    case 9:
                        keepLooping = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        break;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

            } //end of while loop


        } // End of Main method

        static void PrintMenu()
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1: Count down from 3");
            Console.WriteLine("2: Give me code love");
            Console.WriteLine("9: Exit program");
        }

        static string AskUserFor(string what)
        {
            Console.Write("Please enter " + what + ": ");
         /* Console.Write("Please enter {0}: ", what);
            Console.Write($"Please enter {what}: "); */
            return Console.ReadLine();
        }

        static int AskUserForNumber(string what)
        {
            string inputed = AskUserFor(what);

            int number = Convert.ToInt32(inputed);

            return number;
        }

        static void CodeLove()
        {
            int amount = AskUserForNumber("how mush code love do you need?");

            while (amount > 0)
            {
                Console.WriteLine("Code loves you!");
                amount--;
            }
        }

    } //End of Program class
} //End of Namespace
