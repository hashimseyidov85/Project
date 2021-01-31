using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHomework
{
    public class Person
    {
        private Person p;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public Person()
        {
        }

        public Person(Person p)
        {
            this.p = p;
        }
    }
}
