using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Classes
{
    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    public abstract class Visitor
    {
        // Use reflection to see if the Visitor has a method 
        // named Visit with the appropriate parameter type 
        // (i.e. a specific Employee). If so, invoke it.
        public void ReflectiveVisit(IElement element)
        {
            var types = new Type[] { element.GetType() };
            var mi = this.GetType().GetMethod("Visit", types);

            if (mi != null)
            {
                mi.Invoke(this, new object[] { element });
            }
        }
    }
}
