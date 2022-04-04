using InterfaceProject.Comparer;
using System;
using System.Collections;

namespace InterfaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee giorgi = new Employee()
            {
                Name = "Giorgi",
                LastName = "Asanidze",
                BirthTime = new DateTime(1998, 6, 2),
                ID = "010101019032",
                Sallary = 7500,
                Score = 100
            };
            Employee nikolozi = new Employee()
            {
                Name = "Nikolozi",
                LastName = "Sanaia",
                BirthTime = new DateTime(2000, 12, 19),
                ID = "010101019044",
                Sallary = 10000,
                Score = 100
            };
            Employee ucnobi = new Employee()
            {
                Name = "Ucnobi",
                LastName = "Gvari",
                BirthTime = new DateTime(1991, 11, 11),
                ID = "230101019044",
                Sallary = 300,
                Score = 72
            };

            ArrayList staff = new ArrayList();
            staff.Add(giorgi);
            staff.Add(nikolozi);
            staff.Add(ucnobi);


            staff.Sort(new AgeComparer());
            foreach (Employee e in staff)
            {
                Console.WriteLine(e.Age);
            }
            staff.Sort(new SalaryComparer());
            foreach (Employee e in staff)
            {
                Console.WriteLine(e.Sallary);
            }
            staff.Sort(new RaitingComparer());
            foreach (Employee e in staff)
            {
                Console.WriteLine(e.Score);
            }
        }
    }
}
