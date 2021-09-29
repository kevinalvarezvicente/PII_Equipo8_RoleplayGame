using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Items Martillo = new Items("Goloso", 10, 40, 0);

            Dwarves D1 = new Dwarves("Julio");
            Dwarves D2 = new Dwarves("José");
            D1.getAttack();
            D1.getDefense();
            D1.Attack(D2);
            D1.Heal(D2);
            D1.EquipWeapons(Martillo);
            D1.UnequipWeapons(Martillo);

            CharacterWizard W1 = new CharacterWizard(1, "Roberto");
            CharacterWizard W2 = new CharacterWizard(2, "Gorgory");
            W1.Spell(W2, W2);            
            
            Elves E2 = new Elves("ElFito");
            Elves E1 = new Elves("ElPaes");
            E2.getAttack();
            E1.Attack(E2);
        }
    }
}
