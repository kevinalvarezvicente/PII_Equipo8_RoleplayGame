using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarves : Character
    {
        List<Item> ListItems = new List<Item>();
        public int HealSkill { get; set; }
        private Boolean EquippedWeapon { get; set; }


        public Dwarves(int id, string name)
        {
            this.Id = id;
            this.Name = name; 
            this.AttackValue = 25;
            this.DefenseValue = 70;
            this.Health = 100;
            this.HealSkill = 20;
            this.EquippedWeapon = EquippedWeapon;
        }

        public int getAttack()
        {
            Console.WriteLine($"El daño de Julio es {this.AttackValue}");
            return this.AttackValue;
        }
 
        public int getDefense()
        {
            Console.WriteLine($"La defensa de Julio es {this.DefenseValue}");
            return this.DefenseValue;
        }

        public void EquipWeapons(Item item)
        {
            Boolean Cargado = false;
            foreach (Item element in ListItems){
                if (item.Equals(element))
                {
                    Cargado = true;
                }
            }
            if (Cargado == true)
            {
                if (EquippedWeapon == true) {
                    this.AttackValue = this.AttackValue - item.DamageValue;
                    this.DefenseValue = this.DefenseValue - item.DefendValue;
                }
                this.AttackValue = this.AttackValue + item.DamageValue;
                this.DefenseValue = this.DefenseValue + item.DefendValue;
                Console.WriteLine($"The element {item.Name} was equipped.");
            }
            else {
                Console.WriteLine($"You must equip the item called {item.Name} into your list to be capable of use it.");
            }
            
        }
        public void UnequipWeapons(Item item)
        {
                this.AttackValue = this.AttackValue - item.DamageValue;
                this.DefenseValue = this.DefenseValue - item.DefendValue;
                this.Health = this.Health - this.DefenseValue;
        }        
        public void Attack(Dwarves enemy){
            int i = 0;
                while(enemy.Health > 0 && i == 0){
                    enemy.Health = enemy.Health - this.AttackValue;
                    Console.WriteLine($"Al enemigo le queda {enemy.Health} de vida despues del ataque");
                    i = i + 1;
                } 
        }

        public void Heal(Dwarves ally){
            int i = 0;
            while(ally.Health > 0 && ally.Health < 100 && i == 0){
                    ally.Health = ally.Health + this.HealSkill;
                    if (ally.Health > 100){
                        ally.Health = 100;
                    }
                    Console.WriteLine($"La vida del aliado es {ally.Health} despues de curarlo");
                    i = i + 1;

            }  
        }
                         
    }
    
}