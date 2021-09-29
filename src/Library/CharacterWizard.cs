using System;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Library
{
    public class CharacterWizard : Character
    {

       List<Item> ListItems = new List<Item>();
        List<Spell> BookSpells = new List<Spell>();

        private int IdWizard { get; }
        private string Name { get; }
        public int Health { get; set; }
        private int Damage { get; set; }
        public int Defense { get; set; }
        private int Item_Equipped_DamageValue { get; set; }
        private int Item_Equipped_DefendValue { get; set; }
        private double Item_Equipped_MagicLevel { get; set; }
        private int Spell_Equipped_DamageValue { get; set; }
        private int Spell_Equipped_DefenseValue { get; set; }
        private Boolean EquippedWeapon { get; set; }
        private Boolean EquippedSpell { get; set; }

        private double MagicLevel { get; set; }

        public CharacterWizard(int idWizard, string name)
        {
            this.IdWizard = idWizard;
            this.Name = name;
            this.Health = 400;
            this.Damage = 50;
            this.Defense = 200;
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
            Console.WriteLine($"The Damage of the Wizard is {this.Damage}");
            return this.Damage;
        }

        public int getDefense()
        {
            Console.WriteLine($"The Defense of the Wizard is {this.Defense}");
            return this.Defense;
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

        

        public void attackElf(CharacterElf Elf) {
            if (Elf.Defense > 0) {
                int remainingDamage = Elf.Defense - this.Damage ;
                if (remainingDamage > 0)
                {
                    Elf.Defense = Elf.Defense - this.Damage;
                } else {
                    remainingDamage = this.Damage - Elf.Defense;
                    Elf.Defense = 0;
                    Elf.Health = Elf.Health - remainingDamage;
                }
            } 
        }

        public void attackDwarf(CharacterDwarf Dwarf)
        {
            if (Dwarf.Defense > 0)
            {
                int remainingDamage = Dwarf.Defense - this.Damage;
                if (remainingDamage > 0)
                {
                    Dwarf.Defense = Dwarf.Defense - this.Damage;
                }
                else
                {
                    remainingDamage = this.Damage - Dwarf.Defense;
                    Dwarf.Defense = 0;
                    Dwarf.Health = Dwarf.Health - remainingDamage;
                }
            }
        }

        public void attackWizard(CharacterWizard Wizard)
        {
            if (Wizard.Defense > 0)
            {
                int remainingDamage = Wizard.Defense - this.Damage;
                if (remainingDamage > 0)
                {
                    Wizard.Defense = Wizard.Defense - this.Damage;
                }
                else
                {
                    remainingDamage = this.Damage - Wizard.Defense;
                    Wizard.Defense = 0;
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
                    this.Damage = this.Damage - this.Item_Equipped_DamageValue;
                    this.Defense = this.Defense - this.Item_Equipped_DefendValue;
                    this.MagicLevel = this.MagicLevel - this.Item_Equipped_MagicLevel;
                }
                this.Damage = this.Damage + item.DamageValue;
                this.Defense = this.Defense + item.DefendValue;
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

        public void studySpells(Spell spell)
        {
            int delay = 18000;
            Console.WriteLine($"Notice: Your life will be reduced");
            this.Health = this.Health - ((this.Health * 35) / 100); //The life is reduced to make the game fair.
            Console.WriteLine($"The Wizard called {this.Name} is studying a new spell...");
            Thread.Sleep(delay);
            BookSpells.Add(spell);
            Console.WriteLine($"Spell called {spell.Name} was added!");
        }

        public void EquipSpell(Spell spell)
        {
            Boolean Cargado = false;
            foreach (Spell element in BookSpells)
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
                    this.Damage = this.Damage - this.Spell_Equipped_DamageValue;
                    this.Defense = this.Defense - this.Spell_Equipped_DefenseValue;
                }

                this.Damage = this.Damage + spell.DamageValue;
                this.Defense = this.Defense + spell.DefenseValue;
                this.Spell_Equipped_DamageValue = spell.DamageValue;
                this.Spell_Equipped_DefenseValue = spell.DefenseValue;
                Console.WriteLine($"The spell {spell.Name} was equipped");
            }
            else
            {
                Console.WriteLine($"You must equip the spell called {spell.Name} into your list to be capable of use it.");
            }


        }

        public void healWizard(CharacterWizard wizard)
        {
            Console.WriteLine($"La vida del aliado es {ally.Health} despues de curarlo");
        }
    }
}