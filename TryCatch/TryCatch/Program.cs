using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1 - Convert String to Int");
                Console.WriteLine("2 - Divide by zero");
                Console.WriteLine("3 - Null reference");
                Console.WriteLine("4 - Index out of range");
                Console.WriteLine("5 - General exception");

                string optionString = Console.ReadLine();
                int option = ConvertToInt(optionString);

                switch (option) {
                    case 1:
                        Console.WriteLine("Please enter a value:");
                        string userInput = Console.ReadLine();
                        int x = ConvertToInt(userInput);
                        break;
                    case 2:
                        try
                        {
                            int y = option / 0;
                        }
                        catch (Exception dbze) {
                            Console.WriteLine("Divizion by zero exception:");
                            DisplayException(dbze);
                        }                      
                        break;
                    case 3:
                        try
                        {
                            List<string> l = null;
                            l.Add("null reference exception is expected");
                        }
                        catch (NullReferenceException nre) {
                            Console.WriteLine("Null reference exception:");
                            DisplayException(nre);
                        }
                        break;
                    case 4:
                        try
                        {
                            int[] arr = { 1, 2, 3 };
                            int i = arr[10];
                        }
                        catch (IndexOutOfRangeException iore) {
                            Console.WriteLine("Index out of range exception:");
                            DisplayException(iore);
                        }
                        break;
                    case 5:
                        throw new Exception("User created an exception");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("General exception:");
                DisplayException(e);
            }
            finally {
                Console.ReadKey();
            }
        }
        private static void DisplayException(Exception e) {
            Console.WriteLine("Message: "+e.Message);
            Console.WriteLine("Details: "+e.StackTrace);
            Console.WriteLine();
        }
        private static int ConvertToInt(string text) {
            try
            {
                int x = Int32.Parse(text);
                return x;
            }
            catch (FormatException e) {
                Console.WriteLine("Format exception:");
                DisplayException(e);
                Console.WriteLine("Try again:");
                string newInput = Console.ReadLine();
                return ConvertToInt(newInput);
            }
        }
    }
}
