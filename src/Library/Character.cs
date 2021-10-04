using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackValue { get; set; }     
        public int DefenseValue { get; set; }
        

        List<Item> ListItems = new List<Item>();
        public void AddItem(Item item)
        {
            if (ListItems.Count <= 3)
            {
                ListItems.Add(item);
                Console.WriteLine($"The item {item.Name} was added.");
            }
            else
            {
                Console.WriteLine($"You can not have more than 4 items so remove one.");
                Console.WriteLine($"The item called {item.Name} was not added.");
                showItems();
            }
        }

        public void RemoveItem(Item item)
        {
            ListItems.Remove(item);
            Console.WriteLine($"The item {item.Name} was removed.");
            showItems();
        }

        public void showItems()
        {
            Console.WriteLine($"Your items are: ");
            for (int i = 0; i < ListItems.Count; i++)
            {
                Console.WriteLine($"The item {ListItems[i].Name}");
            }
        }

        /*
        public int getAttack()
        {
            Console.WriteLine($"The Damage of the Wizard is {this.AttackValue}");
            return this.AttackValue;
        }
        */

        public void Cure()
        {
             Console.WriteLine("You want to use a potion? y/n");
             
             string r = Console.ReadLine();
             if (r == "y" || r == "Y")
             {
                this.Health = this.Health + 50;
             }
             else if (r == "n" || r == "N")
             {
                
             }
             else
             {
                 Console.WriteLine("You have touch a wrong key");
             }
        }

        public void ReceiveAttack(int power, Character enemy)
        {
            this.Health = this.Health - enemy.AttackValue;
            Console.WriteLine($"your remaining life is {this.Health}");
            
        }

    }
}
