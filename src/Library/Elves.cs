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
        public int HealSkill { get; set; }

        public Elves (string name)
        {
            this.Name = name;
            this.Health = 150;
            this.Damage = 20;
            this.Defense = 80;
            this.Broken = false;
            this.HealSkill = 10;
        }  
        public int getAttack()
        {
            Console.WriteLine(this.Damage);
            return this.Damage;
        }
 
        public int getDefense()
        {
           Console.WriteLine(this.Defense);
           return this.Defense;
        }

        public void Attack(Elves enemy){
            int i = 0;
                while(enemy.Health > 0 && i == 0){
                    enemy.Health = enemy.Health - this.Damage;
                    Console.WriteLine($"La vida del enemigo después del ataque es: {enemy.Health}");

                    i = i + 1;
                } 
        }
        public void Heal(Elves ally){
            while(ally.Health > 0 && ally.Health < 100){
                    ally.Health = ally.Health + this.HealSkill;
                    if (ally.Health > 100){
                        ally.Health = 100;
                    }
                    Console.WriteLine($"La vida del aliado después de curarlo es: {ally.Health}");
            }  
        }

        public void AddSword(Items item)
        {
            if(Broken == false)
            {
                this.Damage = this.Damage + item.AttackValue;
                this.Defense = this.Defense + item.DefendValue;
                this.Health = this.Health + this.Defense;
                
            }
        }
    }
}
