using System;

namespace Library
{
    public class Dwarves
    {
        private string Name { get; set; }

        public int Damage { get; set; }     

        public int Defense { get; set; }

        public int Health { get; set; }

        public Items weapon { get; set; }

        public Items armour { get; set; }

        public Dwarves(string name)
        {
            this.Name = name; 
            this.Damage = 25;
            this.Defense = 70;
            this.Health = 100;
        }

        public void EquipDwarves(Dwarves dwarve, Weapon weapon){

            if(weapon.Broken == false)
            {
                dwarve.Damage = dwarve.Damage + this.Damage;
                dwarve.Defense = dwarve.Defense + this.Defense;
                dwarve.Life = dwarve.Life + dwarve.Defense;
                Console.WriteLine($"daño {dwarve.Damage}");
                Console.WriteLine($"vida {dwarve.Life}");
            }
            
        }

        public void Attack(Dwarves enemy){

            while(enemy.Life > 0){
                    enemy.Life = enemy.Life - this.Damage;
                    Console.WriteLine(enemy.Life);

            } 
        }
                         
    }
    
}