using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public abstract class Person
    {

        protected string name;
        protected int age;

        protected Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name {
            get { return name; }
            set { name = value; } 
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
    }
}
