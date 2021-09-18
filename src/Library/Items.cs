using System;

namespace Library
{
    public class Items
    {
        public string Name { get; private set; }

        public int Damage { get; private set; }

        public int Defense { get; private set; }

        public int Duration { get; private set; }

        public bool Broken { get; set; }

        public int AttackValue { get; set; }

        public int DefendValue{ get; set; }

        public int MagicLevel { get; set; }
      
        public Items (String name,int AttackValue, int DefendValue, int MagicLevel){
            this.Name = name;
            this.AttackValue = AttackValue;
            this.DefendValue = DefendValue;
            this.MagicLevel = MagicLevel;
            this.Duration = 100;
            this.Broken = false;
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