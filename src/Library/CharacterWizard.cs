using System;

namespace Library
{
    public class CharacterWizard
    {

        Items[] WizardItems;

        public CharacterWizard(int IdWizard,string name)
        {
            this.IdWizard = idWizard; 
            this.Name = name; 
            this.Health = 100;
            this.Damage = 25;
            this.Defense = 70;
            this.Broken = false; //Broken
            this.MagicLevel = 0.5;
        }

        public string IdWizard {get;}
        public string Name {get;}
        public int Health {get; private set;}
        public int Damage {get; private set;}
        public int Defense {get; private set;}
        public string MagicLevel {get; private set;}
        

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

        public void EquipWeapons(Items item)
        {
            if(Broken == false)
            {
                this.Damage = this.Damage + item.Damage;
                this.Defense = this.Defense + item.Defense;
                this.Health = this.Health + this.Defense;
                
            }
        }

        public void UnequipWeapons(Items item)
        {
            if(Broken == true)
            {
                this.Damage = this.Damage - item.Damage;
                this.Defense = this.Defense - item.Defense;
                this.Health = this.Health - this.Defense;
                
            }
        }

        public bool IfWeaponIsBroken(Wizard item){
            if(item.Duration == 0){
                item.Broken = true;
            }
            return item.Broken;
        } 
        
        public void Attack(Wizard enemy){
            int i = 0;
                while(enemy.Health > 0 && i == 0){
                    enemy.Health = enemy.Health - this.Damage;
                    Console.WriteLine($"Al enemigo le queda {enemy.Health} de vida despues del ataque");
                    i = i + 1;
                } 
        }

        public void Heal(Wizard ally){
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