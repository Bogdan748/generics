using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGenerics
{
    public class Person : IEquatable<Person> 
    {
        public Person()
            :this ("Not-Specifief-Cnp")
        {

        }

        public Person(string cnp)
        {
            Cnp = cnp;
        }

        public string Cnp { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            return string.Equals(Cnp, other?.Cnp, StringComparison.Ordinal) &&
                string.Equals(FirstName, other?.FirstName, StringComparison.Ordinal) &&
                string.Equals(LastName, other?.LastName, StringComparison.Ordinal);
        }

        public static bool operator ==(Person p1, Person p2)
        {

            if (p1 is null && p2 is null)
            {
                //bpoth are null
                return true;
            }

            if (p1 is null || p2 is null)
            {
                //one is null
                return false;
            }

            //both are not null
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            if (p1 is null && p2 is null)
            {
                //bpoth are null
                return false;
            }

            if (p1 is null || p2 is null)
            {
                //one is null
                return true;
            }

            //both are not null
            return !p1.Equals(p2);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Cnp, FirstName, LastName);
        }

        public void Print()
        {
            Console.WriteLine($"Person: {FirstName} {LastName}, CNP: {Cnp}");
        }

        
    }
}
