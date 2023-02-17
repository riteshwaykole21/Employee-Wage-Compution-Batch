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
            CheckAttendances Dmart = new CheckAttendances("Dmart",20,2,10);
            CheckAttendances relinaces = new CheckAttendances("Reliances", 10, 4, 20);
            Dmart.Attendances();
            Console.WriteLine(Dmart.ToString());
            relinaces.Attendances();
            Console.WriteLine(relinaces.ToString());
            Console.ReadLine();
        }
    }
}
