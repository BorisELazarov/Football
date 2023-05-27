using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Players
{
    public abstract class FootballPlayer : Person
    {
        
        protected int number;
        protected double height;

        protected FootballPlayer(string name, int age, int number, double height) : base(name, age)
        {
            this.number = number;
            this.height = height;
        }

        public int Number {
            get { return number; }
            set { number = value; }
        }
        public double Height {
            get { return height; }
            set { height = value; }
        }
    }
}
