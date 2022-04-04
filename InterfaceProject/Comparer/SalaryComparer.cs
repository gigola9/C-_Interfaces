using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProject.Comparer
{
    public class SalaryComparer : Comparer<Employee>
    {
        public override int Compare(Employee x, Employee y)
        {
            if (x.Sallary < y.Sallary)
            {
                return -1;
            }
            if (x.Sallary > y.Sallary)
            {
                return 1;
            }
            return 0;
        }
    }
}
