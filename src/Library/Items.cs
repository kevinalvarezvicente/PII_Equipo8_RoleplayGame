using System;

namespace Library
{
    public class Items
    {
        ///private int damage {get; set;}

        public string Name { get; private set; }

        public int AttackValue { get; private set; }

        public int DefendValue { get; private set; }

        public int Duration { get; private set; }

        public double MagicLevel { get; set; }

        public bool Broken { get; set; }
      
        public Items (String name,int AttackValue, int DefendValue, int MagicLevel){
            this.Name = name;
            this.AttackValue = AttackValue;
            this.DefendValue = DefendValue;
            this.MagicLevel = MagicLevel;
            this.Duration = 100;
            this.Broken = false;
        }

    }
} 