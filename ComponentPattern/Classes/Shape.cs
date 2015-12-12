using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentPattern.Classes
{
    /// <summary>
    /// Shape class
    /// <remarks>
    /// Implements generic IComparable interface
    /// </remarks>
    /// </summary>

    class Shape : IComparable<Shape>
    {
        string name;

        // Constructor
        public Shape(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        // IComparable<Shape> Member
        public int CompareTo(Shape other)
        {
            return (this == other) ? 0 : -1;
        }
    }
}
