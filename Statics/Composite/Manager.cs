using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public class Manager : Staff
    {
        public Manager(string name):base(name)
        {
            Calculate();
        }

        public override void Calculate()
        {
            Salary = Configer.BaseSalary * 3 + 1000;
        }

        public override void Search()
        {
            Console.WriteLine("Manager name is:" + Name + " ,Salary is " + Salary);
        }
    }
}
