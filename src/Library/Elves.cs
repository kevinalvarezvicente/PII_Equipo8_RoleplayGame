using System;


namespace Library
{
    public class Elves
    {
        public int IdElves{get; private set;}
        public string Name {get;}
        public int Health {get; private set;}
        public int Attack {get; private set;}
        public int Defense {get; private set;}
        public string[] ObjectItem {get; private set;}


        public Elves (string name)
        {
            this.Name = name;
            this.Health = 150;
            this.Attack = 20;
            this.Defense = 80;
        }

        void AddItem(Items item) 
        {

        }

        void UpdateItem(Items item)
        {

        }

        void DeleteItem(Items item)
        {

        }

        int getAttack()
        {
           return this.Attack;
        }

        int getDefense()
        {
           return this.Defense;
        }

        public string HealWizard(Wizard wizard)
        {
            
        }

        public string HealDwarve(Dwarves dwarve)
        {
            
        }

        public string AttackWizard(Wizard wizard)
        {
            
        }

        public string AttackDwarve(Dwarves dwarve)
        {
            
        }





    }
}