using System;


namespace Library
{
    public class Elves
    {
        public string Name {get;}
        public int Health {get; private set;}
        public int Attack {get; private set;}
        public int Defense {get; private set;}
        public string Item {get; private set;}


        public Elves (string name)
        {
            this.Name = name;
            this.Health = 150;
            this.Attack = 20;
            this.Defense = 80;
        }

        Sword Sword = new Sword(20, "ElveSword");
        public void AddSword()
        {
            this.Item = Sword.GetName();
            this.Attack = Attack +  Sword.GetDamage();
        }




    }
}