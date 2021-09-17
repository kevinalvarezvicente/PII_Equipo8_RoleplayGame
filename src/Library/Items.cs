using System;

namespace Library
{
    public class Items
    {
        private int damage {get; set;}
        public int Damage{get;}

        public string Name{get; set;}
        public Sword (int damage, string Name)
        {
            this.Damage = damage;
            this.Name = Name;
        }

        public int GetDamage()
        {
            return this.Damage;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
} 