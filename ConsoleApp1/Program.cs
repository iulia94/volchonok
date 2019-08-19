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
                }
                Console.WriteLine("Would you like to continue? Enter 'Y' to continue.");
                var user_input = Console.ReadLine();
                if (user_input != "Y")
                {
                    h = false;
                }
            }  
           
        }
        
    }
}
