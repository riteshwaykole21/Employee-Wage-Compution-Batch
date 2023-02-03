using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Employee Wage Compution");
            CheckAttendances Empcheck = new CheckAttendances();
            Empcheck.Attendances();
            Console.ReadLine();
         }
    }
}
