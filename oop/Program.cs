using oop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            QaEngineer qa = new QaEngineer();
            qa.FirstName = "Ivan";
            qa.LastName = "Ivanov";
            qa.Gender = "Male";
            qa.Idnp = "200XXX200";
            qa.BirthDate = DateTime.Parse("01/01/1993");
            qa.SalaryPerHour = 120;
            qa.Work();
            qa.CalculateSalary();

            Developer dev = new Developer();
            dev.FirstName = "Petru";
            dev.LastName = "Petrescu";
            dev.Gender = "Male";
            dev.Idnp = "201XXX233";
            dev.BirthDate = DateTime.Parse("05/05/1992");
            dev.SalaryPerHour = 160;
            dev.Work();
            dev.CalculateSalary();
            dev.CalculateSalary(Currency.EUR);

            DevelopmentIntern intern = new DevelopmentIntern();
            intern.FirstName = "Ana";
            intern.LastName = "Anreeva";
            intern.Gender = "Female";
            intern.Idnp = "221XXX244";
            intern.BirthDate = DateTime.Parse("12/11/1995");
            intern.Work();
            intern.CalculateSalary();
            intern.CalculateSalary(Currency.EUR);

            Console.ReadKey();
        }
    }
}
