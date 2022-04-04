using InterfaceExample.Shapes;
using System;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(10, 8);
            Console.WriteLine(rec.ResultOfArea);
            Console.WriteLine(rec.perimeter());
        }
    }
}
