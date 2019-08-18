using ConsoleApp1;
using System;

namespace IuIuIu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select Homework:");
            var user_input = Console.ReadLine();
            int n = Int32.Parse(user_input);
            if (n == 1)
            {
                Homework1.Run();
            }
            else if (n == 2)
            {
                Homework2.Run();
            }
            Console.ReadKey();
        }
        
    }
}
