using System;

namespace Library
{
    public class Elves
    {
        public int IdElves{get; private set;}
        public string Name {get;}
        public int Health {get; private set;}
        public int Damage {get; private set;}
        public int Defense {get; private set;}
        public Array[] ObjectItem {get; private set;}
        public bool Broken { get; set; }
 
        public Elves (string name)
        {
            this.Name = name;
            this.Health = 150;
            this.Damage = 20;
            this.Defense = 80;
            this.Broken = false;
        }
        public int getAttack()
        {
            Console.WriteLine(this.Damage);
            return this.Damage;
        }
 
        int getDefense()
        {
           return this.Defense;
        }
        
        public void AddSword(Items item)
        {
            if(Broken == false)
            {
                this.Damage = this.Damage + item.Damage;
                this.Defense = this.Defense + item.Defense;
                this.Health = this.Health + this.Defense;
                
            }
        }

    }


}