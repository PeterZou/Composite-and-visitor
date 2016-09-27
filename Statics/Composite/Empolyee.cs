using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public class Empolyee: Staff
    {
        public Empolyee(string name):base(name)
        {
            Calculate();
        }

        public override void Calculate()
        {
            Salary = Configer.BaseSalary * 2 + 500;
        }

        public override void Search()
        {
            Console.WriteLine("Empolyee name is:" + Name + " ,Salary is " + Salary);
        }
    }
}
