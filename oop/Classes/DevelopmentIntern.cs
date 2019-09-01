using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Classes
{
    public class DevelopmentIntern:Developer
    {
        public override void Work()
        {
            Console.WriteLine("Development intern is learning to write code");
        }
        public override void CalculateSalary()
        {
            Console.WriteLine("Intern has no salary yet");
        }
        public override void CalculateSalary(Currency currency)
        {
            Console.WriteLine("Intern can't get salary in " + currency);
        }
    }
}
