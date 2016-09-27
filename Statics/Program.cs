using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Corp b = new Manager("b");
            Corp d = new Empolyee("d");
            Corp f = new Empolyee("f");
            Corp g = new Empolyee("g");
            Corp h = new Manager("h");
            Corp i = new Manager("i");
            Corp j = new Manager("j");

            Corp e = new Depart("e");
            e.Add(g);
            e.Add(h);
            e.Add(i);
            e.Add(j);

            Corp c = new Depart("c");
            c.Add(d);
            //c.Add(e);
            c.Add(f);
            c.Add(e);

            Corp a = new Depart("a");
            a.Add(b);
            a.Add(c);

            a.Search();
            SalaryStaticsForDepart s = new SalaryStaticsForDepart();
            a.Accept(s);

            Console.WriteLine(s.Total);
            Console.ReadKey();
        }
    }
}
