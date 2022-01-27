using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Person
    {
        public String Fullname { get; }
        public String Email { get; }
        public String Phone { get; }
        public String Sex { get; }
        public String Age { get; }
        public String PreExisting_Diseases { get; }
        public String Address { get; }
        public String Timestamp { get; }

        public Person(String Fullname, String Email, String Phone, String Sex, String Age, String PreExisting_Diseases, String Address, String Timestamp)
        {
            this.Fullname = Fullname;
            this.Email = Email;
            this.Phone = Phone;
            this.Sex = Sex;
            this.Age = Age;
            this.PreExisting_Diseases = PreExisting_Diseases;
            this.Address = Address;
            this.Timestamp = Timestamp;
        }
    }
}
