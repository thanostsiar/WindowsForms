using System;

namespace project2
{
    class Player
    {
        public String Name { get; }
        public String Email { get; }

        public Player(String Name, String Email)
        {
            this.Name = Name;
            this.Email = Email;
        }
    }
}
