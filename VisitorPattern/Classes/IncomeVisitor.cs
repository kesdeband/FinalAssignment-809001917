using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Classes
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class IncomeVisitor : Visitor
    {
        // Visit clerk
        public void Visit(Clerk clerk)
        {
            DoVisit(clerk);
        }

        // Visit director
        public void Visit(Director director)
        {
            DoVisit(director);
        }

        private void DoVisit(IElement element)
        {
            var employee = element as Employee;

            // Provide 10% pay raise
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}",
                employee.GetType().Name, employee.Name,
                employee.Income);
        }
    }
}
