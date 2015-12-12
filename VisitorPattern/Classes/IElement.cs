using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Classes
{
    public interface IElement
    {
        void Accept(Visitor visitor);
    }
}
