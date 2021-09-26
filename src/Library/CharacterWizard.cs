using System;

namespace Library
{
    public class CharacterWizard
    {

        Spells[] WizardItems;

        public int IdWizard {get;}
        public string Name {get;}
        public int Health {get; set;}
        public int Damage {get; private set;}
        public int Defense {get; private set;}
        public double MagicLevel {get; private set;}
        public int HealSkill {get; set;}
        
        public bool MagicBook { get; set; }

        public bool HaveMagicElement { get; set; }

        public CharacterWizard(int idWizard,string name)
        {
            this.IdWizard = idWizard; 
            this.Name = name; 
            this.Health = 100;
            this.Damage = 25;
            this.Defense = 70;
            this.MagicLevel = 0.5;
            this.MagicBook = true;
        }

        public int getAttack()
        {
            Console.WriteLine($"El daño del Mago es {this.Damage}");
            return this.Damage;
        }
 
        public int getDefense()
        {
            Console.WriteLine($"La defensa de Mago es {this.Defense}");
            return this.Defense;
        }

        public void Spell(CharacterWizard enemy, CharacterWizard ally)
        {    
            if(this.MagicBook == true)
            {
                string i = "";
                Console.WriteLine("Elija el hechizo a usar:\n 1. Fireball\n 2. WaterHeal");
                i = Console.ReadLine();
                if (i == "1")
                {
                    Console.WriteLine("Atacaste con la Fireball!!!");
                    int a = 0;
                    while(enemy.Health > 0 && a == 0)
                    {
                    enemy.Health = enemy.Health - this.Damage;
                    Console.WriteLine($"Al enemigo le queda {enemy.Health} de vida despues de la Bola de Fuego");
                    a = a + 1;
                    } 
                }
                if (i == "2")
                {
                    Console.WriteLine("Curaste un aliado con la WaterBall!!!");
                    while(ally.Health > 0 && ally.Health < 100)
                    {
                        ally.Health = ally.Health + this.HealSkill;
                    if (ally.Health > 100)
                    {
                        ally.Health = 100;
                    }
                    Console.WriteLine($"La vida del aliado es {ally.Health} despues de curarlo");
                    }  
                }
            }
        }

        public void EquipWeapons(Items item)
        {
            if(item.Broken == false)
            {
                this.Damage = this.Damage + item.AttackValue;
                this.Defense = this.Defense + item.DefendValue;
                this.Health = this.Health + this.Defense;
                
            }
        }

        public void EquipMagicElement(MagicElements elements)
        {
            if(elements.Broken == false)
            {
                this.Damage = this.Damage + elements.AttackValue;
                this.Defense = this.Defense + elements.DefendValue;
                this.Health = this.Health + this.Defense;
                
            }
        }

        public void UnequipWeapons(Items item)
        {
            if(item.Broken == true)
            {
                this.Damage = this.Damage - item.AttackValue;
                this.Defense = this.Defense - item.DefendValue;
                this.Health = this.Health - this.Defense;
                
            }
        }

        public void UnequipMagicElements(MagicElements elements)
        {
            if(elements.Broken == true)
            {
                this.Damage = this.Damage - elements.AttackValue;
                this.Defense = this.Defense - elements.DefendValue;
                this.Health = this.Health - this.Defense;
                
            }
        }

        public bool IfWeaponIsBroken(Items item){
            if(item.Duration == 0){
                item.Broken = true;
            }
            return item.Broken;
        } 

        public bool IfElementIsBroken(MagicElements elements){
            if(elements.Duration == 0){
                elements.Broken = true;
            }
            return elements.Broken;
        }
        
        public void Attack(CharacterWizard enemy){
            int i = 0;
                while(enemy.Health > 0 && i == 0){
                    enemy.Health = enemy.Health - this.Damage;
                    Console.WriteLine($"Al enemigo le queda {enemy.Health} de vida despues del ataque");
                    i = i + 1;
                } 
        }

        public void Heal(CharacterWizard ally){
            while(ally.Health > 0 && ally.Health < 100){
                    ally.Health = ally.Health + this.HealSkill;
                    if (ally.Health > 100){
                        ally.Health = 100;
                    }
                    Console.WriteLine($"La vida del aliado es {ally.Health} despues de curarlo");

            }  
        }
    }
}