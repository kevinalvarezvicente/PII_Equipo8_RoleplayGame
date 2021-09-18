using System;

namespace Library
{
    public class Items
    {
        public Items (String name,int AttackValue, int DefendValue, int MagicLevel){
            this.name = name;
            this.AttackValue = AttackValue;
            this.DefendValue = DefendValue;
            this.MagicLevel = MagicLevel;
        }

        public Staff(int damage, string Name)
        {
            this.Damage = damage;
            this.Name = Name;
        }
    }
} 