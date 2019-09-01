using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Worker:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Idnp { get; set; }
        public double SalaryPerHour { get; set; }
        protected const int WorkingHoursPerDay = 8;
        protected const int WorkingDaysPerMonth = 22;
        public virtual void Work() {
            Console.WriteLine("Worker is working");
        }
        public virtual void CalculateSalary() {
            double salary = SalaryPerHour * WorkingHoursPerDay * WorkingDaysPerMonth;
            Console.WriteLine("Salary is "+salary);
        }
    }
}
