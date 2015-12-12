using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Classes
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    class Employees : List<Employee>
    {
        public void Attach(Employee employee)
        {
            Add(employee);
        }

        public void Detach(Employee employee)
        {
            Remove(employee);
        }

        public void Accept(Visitor visitor)
        {
            // Iterate over all employees and accept visitor
            this.ForEach(employee => employee.Accept(visitor));

            Console.WriteLine();
        }
    }
}
