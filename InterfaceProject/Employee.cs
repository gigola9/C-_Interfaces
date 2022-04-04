using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfaceProject
{
    public class Employee : IEnumerable<Employee>, IEnumerator<Employee>, IComparable<Employee>, IEquatable<Employee>, IComparer<Employee>, IComparable
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public DateTime BirthTime { get; set; }
        public double Sallary { get; set; }
        public int Score { get; set; }
        public int Age => DateTime.Now.Month < BirthTime.Month ? DateTime.Now.Year - BirthTime.Year - 1 : DateTime.Now.Year - BirthTime.Year;
        public int current;

        public Employee Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public int Compare(Employee x, Employee y) // შეგვიძლია ცალკე Compare -ებიც ვწეროთ როგორც Comparer ფოლდერშია ან აქვე შევცვალოთ
        {
            if (x.Age < y.Age)
            {
                return -1;
            }
            if (x.Age > y.Age)
            {
                return 1;
            }
            return 0;
        }


        public int CompareTo(Employee y)
        {
            if (this.Age < y.Age)
            {
                return -1;
            }
            if (Age > y.Age)
            {
                return 1;
            }
            return 0;
        }

        public int CompareTo(object obj)
        {
            Employee y = (Employee)obj;
            if (this.Age < y.Age)
            {
                return -1;
            }
            if (Age > y.Age)
            {
                return 1;
            }
            return 0;
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public bool Equals(Employee other)
        {
            return Age == other.Age &&
                   Sallary == other.Sallary &&
                   Name == other.Name &&
                   LastName == other.LastName &&
                   Score == other.Score &&
                   ID == other.ID &&
                   BirthTime == other.BirthTime;
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool MoveNext()
        {
            current++;
            return this.MoveNext();
        }

        public void Reset()
        {
            current = 1;
        }
    

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
