using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public interface Visitor
    {
        void Visit(Staff corp);

        void Visit(Depart corp);
    }
}
