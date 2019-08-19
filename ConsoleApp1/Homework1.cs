using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Homework1
    {
        public static void Run()
        {
            Console.WriteLine("Enter the number of task:");

            int homework_nr = Utilities.Enter_int();
            if (homework_nr == 1)
            {
                Task_one();
            }
            else if (homework_nr == 2)
            {
                Task_two();
            }
            else if (homework_nr == 3)
            {
                Task_three();
            }
            else if(homework_nr==4)
            {
                Task_four();
            }
            else
            {
                Console.WriteLine("No such task.");
            }
            
        }
        public static void Task_one()
        {
            Console.WriteLine("Enter your age:");

            int age = Utilities.Enter_int();

            if (age >= 0 && age <= 14)
            {
                Console.WriteLine("neangajat");
            }
            else if (age > 14 && age <= 18)
            {
                Console.WriteLine("angajat, part-time");
            }
            else if (age > 18 && age <= 65)
            {
                Console.WriteLine("angajat, full time");
            }
            else if (age > 65)
            {
                Console.WriteLine("neangajat");
            }
            else
            {
                Console.WriteLine("invalid age");
            }

        }
        public static void Task_two()
        {
            Console.WriteLine("Enter radius:");

            double radius = Utilities.Enter_double();
            const double pi = 3.14;
            double perimeter = 2 * pi * radius;
            double aria = pi * radius * radius;
            double diameter = 2 * radius;

            Console.WriteLine("Perimeter is " + perimeter);
            Console.WriteLine("Aria is " + aria);
            if (diameter > 6)
            {
                Console.WriteLine("Nu poate fi inscris.");
            }
            else
            {
                Console.WriteLine("Poate fi incris");
            }
        }
        public static double Task_three()
        {
            Console.WriteLine("1.Bread - 5 lei");
            Console.WriteLine("2.Tea - 25 lei");
            Console.WriteLine("3.Cheese - 65 lei");
            Console.WriteLine("4.Water - 10 lei");
            Console.WriteLine("Choose products:");

            int option = Utilities.Enter_int();
            int price = 0;
            switch (option)
            {
                case 1:
                    price = 5;
                    break;
                case 2:
                    price = 25;
                    break;
                case 3:
                    price = 65;
                    break;
                case 4:
                    price = 10;
                    break;
                default:
                    Console.WriteLine("Product not found");
                    break;
            }
            Console.WriteLine("Please enter amount of the product:");

            int amout = Utilities.Enter_int();
            double total_price = amout * price * 1.2;
            Console.WriteLine("The total price with TVA is:" + total_price);
            return total_price;
        }
        public static void Task_four()
        {
            Console.WriteLine("Please enter the number:");

            int number = Utilities.Enter_int();

            //if is positive
            if (number >= 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else Console.WriteLine("The number is negative.");

            //if is even
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else Console.WriteLine("The number is odd.");

            //if is prime
            bool is_prime = true;
            for (int x = 2; x < number; x++)
            {
                if (number % x == 0)
                {
                    is_prime = false;
                    Console.WriteLine("The number is not prime.");
                    break;
                }
            }
            if (is_prime == true)
            {
                Console.WriteLine("This is prime number.");
            }

            //if is multiple of 5
            if (number % 5 == 0)
            {
                Console.WriteLine("The numbet is multiple of 5.");
            }
            else Console.WriteLine("The number is not multiple of 5.");

            //if is square of a number
            bool is_square = false;
            for (int x = number * -1; x <= number; x++)
            {
                int square = x * x;
                if (square == number)
                {
                    Console.WriteLine("The number is square of a number.");
                    is_square = true;
                    break;
                }
            }
            if (is_square == false)
            {
                Console.WriteLine("The number is not square of any number.");
            }
        }
    }
}
