using System;

namespace Library
{
    public class Items
    {
        ///private int damage {get; set;}

        public string Name { get; private set; }

        public int Damage { get; private set; }

        public int Defense { get; private set; }

        public int Duration { get; private set; }

        public bool Broken { get; set; }

        public Item (int damage, string name)
        {
            this.Name = name;
            this.Damage = damage;
            this.Defense = defense;
            this.Duration = 100;
            this.Broken = false;
        }

        public int GetDamage()
        {
            return this.damage;
        }
        public string GetName()
        {
            return this.name;
        }

        public void EquipWeapons(Dwarves dwarve)
        {
            if(Broken == false)
            {
                dwarve.Damage = dwarve.Damage + this.Damage;
                dwarve.Defense = dwarve.Defense + this.Defense;
                dwarve.Health = dwarve.Health + dwarve.Defense;
                
            }
        }

        public void UnequipWeapons(Dwarves dwarve)
        {
            if(Broken == true)
            {
                dwarve.Damage = dwarve.Damage - this.Damage;
                dwarve.Defense = dwarve.Defense - this.Defense;
                dwarve.Life = dwarve.Life - dwarve.Defense;
                
            }
        }

        public bool IfWeaponIsBroken(){
            if(this.Duration == 0){
                this.Broken = true;
            }
            return this.Broken;
        }   
    }
} 