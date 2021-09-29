using System;

namespace Library
{
    class Item
    {
            public string Name { get; }
            public int DamageValue { get; }
            public int DefendValue { get; }
            public double MagicLevel { get; }

            public Item(String name, int damageValue, int defendValue, double magicLevel)
            {
                this.Name = name;
                this.DamageValue = damageValue;
                this.DefendValue = defendValue;
                this.MagicLevel = magicLevel;
            }
    }
} 