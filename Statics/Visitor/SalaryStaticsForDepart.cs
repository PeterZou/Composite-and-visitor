using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public class SalaryStaticsForDepart : Visitor
    {
        public int Total { get; set; }

        private Stack<Tuple<Corp, int, int>> temp =
            new Stack<Tuple<Corp, int, int>>();

        public void Visit(Depart corp)
        {
            temp.Push(new Tuple<Corp, int, int>(corp, ((Depart)corp).corps.Count, 0));
            VisitRecursive(corp);
        }

        private void VisitRecursive(Corp corp)
        {
            var cop = corp as Depart;
            if (cop != null)
            {
                foreach (var c in cop.corps)
                {
                    var co = c as Depart;
                    if (co != null)
                    {
                        temp.Push(new Tuple<Corp, int, int>
                        (co, co.corps.Count, 0)
                        );
                        VisitRecursive(c);
                    }
                    else
                    {
                        var sta = c as Staff;
                        temp.Push(new Tuple<Corp, int, int>
                        (sta, 1, sta.Salary)
                        );
                        PopMethod();
                    }
                }
            }
        }

        private void PopMethod()
        {
            //判断子元素必须大于3
            //弹栈
            //判断数量是否符合
            Stack<Tuple<Corp, int, int>> temp2 =
                new Stack<Tuple<Corp, int, int>>();

            if (temp.Count > 3)
            {
                int temp2Num = 1;
                var elePop1 = temp.Pop();
                temp2.Push(elePop1);
                var elePop2 = temp.Pop();
                temp2.Push(elePop2);
                Total = elePop1.Item3;

                while (true)
                {
                    if (elePop2.Item2 > 1)
                    {
                        if (temp2Num == elePop2.Item2)
                        {
                            temp.Push(new Tuple<Corp, int, int>(
                                elePop2.Item1, 1, Total));
                            if (temp.Count == 1) break;
                            Total = 0;
                            temp2Num = 1;
                            temp2.Clear();
                            elePop1 = temp.Pop();
                            temp2.Push(elePop1);
                            elePop2 = temp.Pop();
                            temp2.Push(elePop2);
                            Total = elePop1.Item3;
                        }
                        else
                        {
                            //压栈发现不匹配，回滚
                            //将压到temp2中的所有数据重新回滚到temp中
                            foreach (var v in temp2)
                            {
                                temp.Push(v);
                            }
                            Total = 0;
                            temp2.Clear();
                            break;
                        }
                    }

                    Total += elePop2.Item3;
                    temp2Num++;

                    elePop1 = elePop2;
                    elePop2 = temp.Pop();
                    temp2.Push(elePop2);
                }
            }
            else if (temp.Count == 1 || temp.Count == 2)
            {
                return;
            }
            else
            {
                var elePop1 = temp.Pop();
                temp2.Push(elePop1);
                var elePop2 = temp.Pop();
                temp2.Push(elePop2);
                var elePop3 = temp.Pop();
                temp2.Push(elePop3);

                if (elePop3.Item2 == 2)
                {
                    Total = elePop1.Item3 + elePop2.Item3;
                    temp.Push(new Tuple<Corp, int, int>(
                                elePop3.Item1, 1, Total));

                    Total = 0;
                    temp2.Clear();
                }
                else
                {
                    temp.Push(elePop3);
                    temp.Push(elePop2);
                    temp.Push(elePop1);
                }
            }
            
        }

        public void Visit(Staff corp)
        {
            Console.WriteLine("Name is: " + corp.Name + " salary is: " + corp.Salary);
        }
    }
}
