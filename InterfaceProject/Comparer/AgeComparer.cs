using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProject.Comparer
{
    public class AgeComparer: Comparer<Employee>
    {
        public override int Compare(Employee x, Employee y)
        {
            if (x.Age < y.Age)
            {
                return 1;
            }
            if (x.Age > y.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
