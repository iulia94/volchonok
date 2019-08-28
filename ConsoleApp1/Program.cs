using ConsoleApp1;
using System;

namespace IuIuIu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool h = true;
            while (h == true)
            {
                Console.WriteLine("Please select Homework:");

                int n = Utilities.Enter_int();

                if (n == 1)
                {
                    Homework1.Run();
                }
                else if (n == 2)
                {
                    Homework2.Run();
                }
                else
                {
                    Console.WriteLine("No such Homework!");
                    continue;
                }
                h = Continue(h);

            }

        }
        private static bool Continue(bool h)
        {
            Console.WriteLine("Would you like to continue?(Y/N)");
            var user_input = Console.ReadLine();
            if (user_input.ToLower() == "y")
            {
                h = true;
            }
            else if (user_input.ToLower() == "n")
            {
                h = false;
            }
            else
            {
                Console.WriteLine("No such option. Try again.");
                h = Continue(h);
            }
            return h;
        }
        
    }
}
