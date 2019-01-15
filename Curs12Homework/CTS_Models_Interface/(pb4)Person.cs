using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_Models_Interface
{
    public class Person
    {
        public string Name;
        public int Age;

        public override string ToString()
        {
            if (this.Age == 0)
                return "\n\t Age of person not specified!";
            else
                return "\n\t name: " + this.Name + ", age: " + this.Age;
        }
    }
}
