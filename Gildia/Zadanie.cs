using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gildia
{
    public class Zadanie 
    {
        private string name;
        private int nagroda;

        public Zadanie(string name, int nagroda)
        {
            this.name = name;
            this.nagroda = nagroda;
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Nagroda { 
            get { return this.nagroda; }
            set { this.nagroda = value; }
        }

        public override string ToString()
        {
            return "Zadanie: " + this.name + ", nagroda: " + this.nagroda ;
        }
    }
}
