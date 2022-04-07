using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public interface Shape : FunctionsOfShape
    {
        double ResultOfPeriemter { get; set; }
        double ResultOfArea { get; set; }
        double diagonal();
    }
}
