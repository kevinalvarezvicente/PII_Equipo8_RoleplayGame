using System;

namespace Library
{
    public class Wizards
    {
        public string Name {get;}
        public int Attack {get; private set;}
        public int Health {get; private set;}
        public int Defense {get; private set;}
        public string Item {get; private set;}

        public Wizards (string name)
        {
            this.Name = name;
            this.Attack = 50;
            this.Health = 100;
            this.Defense = 90;
        }
        
        public void AddStaff()
        {
            this.Item = Staff.GetName();
            this.Attack = Attack + Staff.GetDamage()
        }
    }
}