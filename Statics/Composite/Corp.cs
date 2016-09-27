using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public abstract class Corp
    {
        public Corp(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract void Add(Corp corp);

        public abstract void Remove(Corp corp);

        public abstract void Search();

        public abstract void Accept(Visitor visitor);
    }
}
