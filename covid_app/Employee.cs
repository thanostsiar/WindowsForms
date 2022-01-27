using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Employee
    {
        public String ID { get; }
        public String Name { get; }
        public int Password { get; }

        public Employee(String ID, String Name, int Password)
        {
            this.ID = ID;
            this.Name = Name;
            this.Password = Password;
        }
    }
}
