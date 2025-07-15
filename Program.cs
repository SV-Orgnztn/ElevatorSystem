using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class LiftMenu
    {
        public static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Hello World FROM VS");

                Console.WriteLine("1. View Lift Status");
                Console.WriteLine("2. Call lift from a floor(up/down)");
                Console.WriteLine("3. Select destination floor from inside the lift");
                Console.WriteLine("4. Advance simulation step (move lifts)");
                Console.WriteLine("5. Exit program");
                Console.Write("Choose an option (1-5): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("1");
                        break;

                    case "2":
                        Console.WriteLine("2");
                        break;

                    case "3":
                        SelectDestination();
                        break;
                    case "4":
                        Console.WriteLine("4");
                        break;

                    case "5":
                        Console.WriteLine("5");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice: ");
                        break;

                }

            }

        }
        public static void SelectDestination()
        {
            Console.WriteLine("In SELECT DESTINATION");

            

        }
       
    }
}
