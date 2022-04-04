using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfaceProject.Comparer
{
    public class RaitingComparer : Comparer<Employee>
    {
        public override int Compare(Employee x, Employee y)
        {
            if (x.Score < y.Score)
            {
                return -1;
            }
            if (x.Score > y.Score)
            {
                return 1;
            }
            return 0;
        }


    }
}
