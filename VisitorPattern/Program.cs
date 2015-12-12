using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Classes;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup employee collection
            var employee = new Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());

            // Employees are 'visited'
            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());

            // Wait for user
            Console.ReadKey();
        }
    }
}
