using System;

namespace GamePolymorphism
{
    public class MainClass
    {
        public static void Main(String[] args)
        {
            Hero h = new Hero();
            h = new Knight();
            h = new Wizard();

            Knight k = new Knight();
            k.baseDamage = 100;
            k.name = "Arthur";
            k.bonusArmor = 50;

            h = k;
            h.UseSkill ();

            k.UseSkill ();
        }
    }
}