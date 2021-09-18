using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elves E2 = new Elves("ElveSword");
            Elves E1 = new Elves("ElveSword");
            E2.getAttack();
            D1.getAttack();
            D1.EquipWeapons(Martillo);
            D1.UnequipWeapons(Martillo);
            E1.Attack(E2);
        }
    }
}
