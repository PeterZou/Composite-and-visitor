using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public class Depart : Corp
    {
        public IList<Corp> corps = new List<Corp>();

        public Depart(string name) :base(name)
        {
        }

        public override void Add(Corp corp)
        {
            corps.Add(corp);
        }

        public override void Remove(Corp corp)
        {
            throw new NotImplementedException();
        }

        public override void Search()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Depart name is: " + Name);

            foreach(var c in corps)
            {
                c.Search();
            }
            Console.WriteLine("-----------------------------");
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
