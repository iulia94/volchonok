using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Utilities
    {
        public static int Enter_int()
        {
            var user_input = Console.ReadLine();

            int x=0;
            try
            {
                x = Int32.Parse(user_input);
                return x;
            }
            catch (Exception)
            {
                Console.WriteLine("This is not an integer! Try again.");
                return Enter_int();
            }
        }
        public static double Enter_double()
        {
            var user_input = Console.ReadLine();
            double x = 0;
            try
            {
                x = double.Parse(user_input);
                return x;
            }
            catch (Exception)
            {
                Console.WriteLine("This is not a decimal! Try again.");
                return Enter_double();
            }
        }
        public static void Display_array(int[] array)
        {
            for (int x = 0; x < array.Length; x++) //x - index
            {
                Console.Write(array[x] + " ");
            }
            Console.WriteLine(""); // enter
        }
        public static void Display_array(char[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x]);
            }
            Console.WriteLine("");
        }
    }
}
