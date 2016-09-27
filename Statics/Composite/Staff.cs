using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public abstract class Staff : Corp
    {
        public int Salary { set; get; }

        public Staff(string name):base(name)
        {
            
        }

        public override void Add(Corp corp)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Corp corp)
        {
            throw new NotImplementedException();
        }

        public override abstract void Search();

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public abstract void Calculate();
    }
}
