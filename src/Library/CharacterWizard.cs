using System;
using System.Collections.Generic;
using System.Threading;

namespace Library
{
    public class CharacterWizard : Character
    {

       List<Item> ListItems = new List<Item>();
       List<MagicElements> ListElements = new List<MagicElements>();
        List<Spells> BookSpells = new List<Spells>();

        private int Item_Equipped_DamageValue { get; set; }
        private int Item_Equipped_DefendValue { get; set; }
        private double Item_Equipped_MagicLevel { get; set; }
        private int Spell_Equipped_DamageValue { get; set; }
        private int Spell_Equipped_DefenseValue { get; set; }
        private Boolean EquippedWeapon { get; set; }
        private Boolean EquippedSpell { get; set; }

        private double MagicLevel { get; set; }

        public CharacterWizard(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Health = 400;
            this.AttackValue = 50;
            this.DefenseValue = 200;
            this.MagicLevel = 0.5;
            this.Item_Equipped_DamageValue = 0;
            this.Item_Equipped_DefendValue = 0;
            this.Item_Equipped_MagicLevel = 0;
            this.Spell_Equipped_DamageValue = 0;
            this.Spell_Equipped_DefenseValue = 0;
            this.EquippedWeapon = false;
            this.EquippedSpell = false;
        }

        public int getAttack()
        {
            Console.WriteLine($"The Damage of the Wizard is {this.AttackValue}");
            return this.AttackValue;
        }

        public int getDefense()
        {
            Console.WriteLine($"The Defense of the Wizard is {this.DefenseValue}");
            return this.DefenseValue;
        }

        public void studyMagic()
        {
            int delay = 15000;
            Console.WriteLine($"Notice: Your life will be reduced");
            this.Health = this.Health - ((this.Health * 20) / 100); //The life is reduced to make the game fair.
            Console.WriteLine($"The Wizard called {this.Name} is studying...");
            this.MagicLevel = this.MagicLevel + (this.MagicLevel * 25) / 100; //The magic is increased 25 per cent.
            Thread.Sleep(delay);
        }

        

        public void attackElf(Elves Elf) {
            if (Elf.DefenseValue > 0) {
                int remainingDamage = Elf.DefenseValue - this.AttackValue ;
                if (remainingDamage > 0)
                {
                    Elf.DefenseValue = Elf.DefenseValue - this.AttackValue;
                } else {
                    remainingDamage = this.AttackValue - Elf.DefenseValue;
                    Elf.DefenseValue = 0;
                    Elf.Health = Elf.Health - remainingDamage;
                }
            } 
        }

        public void attackDwarf(Dwarves Dwarf)
        {
            if (Dwarf.DefenseValue > 0)
            {
                int remainingDamage = Dwarf.DefenseValue - this.AttackValue;
                if (remainingDamage > 0)
                {
                    Dwarf.DefenseValue = Dwarf.DefenseValue - this.AttackValue;
                }
                else
                {
                    remainingDamage = this.AttackValue - Dwarf.DefenseValue;
                    Dwarf.DefenseValue = 0;
                    Dwarf.Health = Dwarf.Health - remainingDamage;
                }
            }
        }

        public void attackWizard(CharacterWizard Wizard)
        {
            if (Wizard.AttackValue > 0)
            {
                int remainingDamage = Wizard.DefenseValue - this.AttackValue;
                if (remainingDamage > 0)
                {
                    Wizard.DefenseValue = Wizard.DefenseValue - this.AttackValue;
                }
                else
                {
                    remainingDamage = this.AttackValue - Wizard.DefenseValue;
                    Wizard.DefenseValue = 0;
                    Wizard.Health = Wizard.Health - remainingDamage;
                }
            }
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
                    this.AttackValue = this.AttackValue - this.Item_Equipped_DamageValue;
                    this.DefenseValue = this.DefenseValue - this.Item_Equipped_DefendValue;
                    this.MagicLevel = this.MagicLevel - this.Item_Equipped_MagicLevel;
                }
                this.AttackValue = this.AttackValue + item.DamageValue;
                this.DefenseValue = this.DefenseValue + item.DefendValue;
                this.MagicLevel = this.MagicLevel + item.MagicLevel;
                this.Item_Equipped_DamageValue = item.DamageValue;
                this.Item_Equipped_DefendValue = item.DefendValue;
                this.Item_Equipped_MagicLevel = item.MagicLevel;
                Console.WriteLine($"The element {item.Name} was equipped.");
            }
            else {
                Console.WriteLine($"You must equip the item called {item.Name} into your list to be capable of use it.");
            }
            
        }

        public void studySpells(Spells spell)
        {
            int delay = 18000;
            Console.WriteLine($"Notice: Your life will be reduced");
            this.Health = this.Health - ((this.Health * 35) / 100); //The life is reduced to make the game fair.
            Console.WriteLine($"The Wizard called {this.Name} is studying a new spell...");
            Thread.Sleep(delay);
            BookSpells.Add(spell);
            Console.WriteLine($"Spell called {spell.Name} was added!");
        }

        public void AddSpell(Spells spell)
        {
            Boolean Cargado = false;
            foreach (Spells element in BookSpells)
            {
                if (spell.Equals(element))
                {
                    Cargado = true;
                }
            }
            if (Cargado == true)
            {
                if (EquippedSpell == true)
                {
                    this.AttackValue = this.AttackValue - this.Spell_Equipped_DamageValue;
                    this.DefenseValue = this.DefenseValue - this.Spell_Equipped_DefenseValue;
                }

                this.AttackValue = this.AttackValue + spell.Attack;
                this.DefenseValue = this.DefenseValue + spell.Defense;
                this.Spell_Equipped_DamageValue = spell.Attack;
                this.Spell_Equipped_DefenseValue = spell.Defense;
                Console.WriteLine($"The spell {spell.Name} was equipped");
            }
            else
            {
                Console.WriteLine($"You must equip the spell called {spell.Name} into your list to be capable of use it.");
            }


        }

        public void RemoveSpell(Spells spell)
        {
            Boolean Cargado = false;
            foreach (Spells element in BookSpells)
            {
                if (spell.Equals(element))
                {
                    Cargado = true;
                }
            }
            if (Cargado == true)
            {
                if (EquippedSpell == true)
                {
                    this.AttackValue = this.AttackValue - this.Spell_Equipped_DamageValue;
                    this.DefenseValue = this.DefenseValue - this.Spell_Equipped_DefenseValue;
                }

                Console.WriteLine($"The spell {spell.Name} was unequipped");
            }
        }

        public void healWizard(CharacterWizard wizard)
        {
            Console.WriteLine($"La vida del aliado es {wizard.Health} despues de curarlo");
        }

        public void AddElement(MagicElements elements)
        {
            if (ListItems.Count <= 3)
            {
                ListElements.Add(elements);
                Console.WriteLine($"The item {elements.Name} was added.");
            }
            else
            {
                Console.WriteLine($"You can not have more than 4 elements so remove one.");
                Console.WriteLine($"The item called {elements.Name} was not added.");
            }
        }

        public void RemoveElements(MagicElements elements)
        {
            ListElements.Remove(elements);
            Console.WriteLine($"The item {elements.Name} was removed.");
        }
    }
}