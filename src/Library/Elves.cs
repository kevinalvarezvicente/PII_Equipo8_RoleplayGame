using System;

namespace Library
{
    public class Elves : Character
    {
        public Array[] ObjectItem {get; private set;}
        public int HealSkill { get; set; }

        public Elves (int id, string name, int VictoryPoints)
        {
            this.Id = id;
            this.Name = name;
            this.Health = 150;
            this.AttackValue = 20;
            this.DefenseValue = 80;
            this.HealSkill = 10;
            // this.VictoryPoints = 0;
        }  
        
        // public int getAttack()
        // {
        //     Console.WriteLine(this.Damage);
        //     return this.Damage;
        // }
 
        public int getDefense()
        {
           Console.WriteLine(this.DefenseValue);
           return this.DefenseValue;
        }

        public void Attack(Elves enemy){
            int i = 0;
                while(enemy.Health > 0 && i == 0){
                    enemy.Health = enemy.Health - this.AttackValue;
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

    }
}
