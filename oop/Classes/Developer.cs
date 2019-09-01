using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Developer:Worker
    {
        public override void Work()
        {
            Console.WriteLine("Developer is coding");
        }
        public virtual void CalculateSalary(Currency currency) {
            double salary = SalaryPerHour * WorkingHoursPerDay * WorkingDaysPerMonth;
            switch (currency) {
                case Currency.EUR:
                    salary = salary / 19.75;
                    break;
                case Currency.GBR:
                    salary = salary / 21.75;
                    break;
                case Currency.RUB:
                    salary = salary * 0.27;
                    break;
                case Currency.UAH:
                    salary = salary * 0.71;
                    break;
                case Currency.USD:
                    salary = salary / 17.83;
                    break;                    
            }
            Console.WriteLine("Salary in " + currency + " is " + salary);
        }
    }
}
