using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Homework2
    {
        public static void Run() {
            Console.WriteLine("Please enter number of task:");

            int n = Utilities.Enter_int();
            if (n == 1)
            {
                Task_one();
            }
            else if (n == 2)
            {
                Task_two();
            }
            else if (n == 3)
            {
                Task_three();
            }
            else if (n == 4)
            {
                Task_four();
            }
            else
            {
                Console.WriteLine("No such task.");
                Run();
            }
        }
        public static void Task_one()
        {
            int[] array = { 3, 61, 9, 15, 57, 36, -4, 23, 18 };
            Console.WriteLine("Array:");
            Utilities.Display_array(array);
            Console.WriteLine("Array after bubble sort:");
            Bubble_sort(array);
            Console.WriteLine("Array after shaker sort:");
            Shaker_sort(array);
        }

        private static void Shaker_sort(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++) {
                bool swapped = false;
                for (int j = i; j < array.Length - i - 1; j++) {
                    if (array[j] < array[j+1]) {
                        int tmp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = tmp;
                        swapped = true;
                    }
                }
                for (int j = array.Length - 2 - i; j > i; j--) {
                    if (array[j] > array[j-1]) {
                        int tmp = array[j];
                        array[j] = array[j-1];
                        array[j-1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            Utilities.Display_array(array);
        }

        private static void Bubble_sort(int[] array)
        {
            var n = array.Length;
            while (n > 0)
            {
                var newn = 0;
                for (var i = 1; i <= n - 1; i++)
                {
                    if (array[i - 1] < array[i])
                    {
                        var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        newn = i;
                    }
                }
                n = newn;
            }
            Utilities.Display_array(array);
        }



        public static void Task_two()
        {
            Console.WriteLine("Please enter a word:");
            string user_input = Console.ReadLine();

            bool n = true;

            for (int x = 0; x < user_input.Length/2; x++)
            {
                if (user_input[x] != user_input[user_input.Length - 1 - x]) {
                    n = false;
                    Console.WriteLine("The word is not a palindrom.");
                    break;
                }
                
            }
            if (n== true) { Console.WriteLine("The word is palindrom.");
            }
        }

        public static void Task_three()
        {
            Console.WriteLine("Please inter a word.");
            string user_input = Console.ReadLine();
            char[] array = user_input.ToArray();
            for (int x = 0; x < array.Length/2; x++)
            {
                char c = array[x];
                array[x] = array[array.Length - 1 - x];
                array[array.Length - 1 - x] = c;
            }
            Console.WriteLine("Reversed word:");
            Utilities.Display_array(array);
        }
        public static void Task_four ()
        {
            Console.WriteLine("Please enter the number of products you want to buy:");

            int n = Utilities.Enter_int();
            double sum = 0;
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine("Product " + (x + 1));
                sum += Homework1.Task_three();
            }
            Console.WriteLine("The Total price of order:" + sum);
        }
    }
}
