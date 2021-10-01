using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Character
    {
        public string Name {get; protected set;}
        public int Health {get; protected set;}
        public int Damage {get; protected set;}
        public int Defense {get; protected set;}
        public int VictoryPoints {get; protected set;}
        
        List<Item> ListItems = new List<Item>();
        void addItem(Item item)
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

        void deleteItem(Item item)
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

        public int getAttack()
        {
            Console.WriteLine($"The Damage is {this.Damage}");
            return this.Damage;
        }

    }
}
