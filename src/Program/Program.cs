using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarves D1 = new Dwarves("Julio");
            Dwarves D2 = new Dwarves("Julio");
            Items Martillo = new Items(10, 40, "Goloso");
            D1.getAttack();
            D1.getDefense();
            D1.Attack(D2);
            D1.Heal(D2);
            D1.EquipWeapons(Martillo);
            D1.UnequipWeapons(Martillo);
            Items Tijera = new Items(12, 25, "Tijera");
            Items Botella = new Items(16, 32, "Botella");
            Elves E2 = new Elves("ElveSword");
            Elves E1 = new Elves("ElveSword");
            E2.getAttack();
            E1.Attack(E2);
        }
    }
}
