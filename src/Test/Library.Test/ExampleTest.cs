using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }

        [Test]
        public void DwarveStadistics()
        {
            Dwarves D1 = new Dwarves("Julio");
            D1.getAttack();
            D1.getDefense();
    
        }

        [Test]
        public void DwarvesAtackAndHeal()
        {
            Dwarves D1 = new Dwarves("Julio");
            Dwarves D2 = new Dwarves("José");
            D1.Attack(D2);
            D1.Heal(D2);
        }

        [Test]
        public void DwarvesWeapons()
        {
            Items Martillo = new Items("Goloso", 10, 40, 0);
            Dwarves D1 = new Dwarves("Julio");
            Dwarves D2 = new Dwarves("José");
            
            D1.EquipWeapons(Martillo);
            D1.getAttack();
            D1.getDefense();
            D1.UnequipWeapons(Martillo);
            D1.getAttack();
            D1.getDefense();
            
        }


    }


}