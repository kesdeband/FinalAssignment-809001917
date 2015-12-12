using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Classes
{
    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    class Employee : IElement
    {
        // Constructor
        public Employee(string name, double income,
            int vacationDays)
        {
            this.Name = name;
            this.Income = income;
            this.VacationDays = vacationDays;
        }

        // Gets or sets name
        public string Name { get; set; }

        // Gets or set income
        public double Income { get; set; }

        // Gets or sets vacation days
        public int VacationDays { get; set; }

        public virtual void Accept(Visitor visitor)
        {
            visitor.ReflectiveVisit(this);
        }
    }
}
