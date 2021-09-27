using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Character
    {
        List<Item> ListItems = new List<Item>();
        public void addItem(Item item)
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

        public void deleteItem(Item item)
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
            Console.WriteLine($"The Damage of the Wizard is {this.Damage}");
            return this.Damage;
        }

    }
}
