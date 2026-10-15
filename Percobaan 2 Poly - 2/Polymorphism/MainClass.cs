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

            Hero[] arrHero = new Hero[3];
            Knight kn = new Knight();
            kn.name = "Lancelot";
            kn.baseDamage = 120;
            kn.bonusArmor = 80;

            arrHero[0] = h;
            arrHero[1] = k;
            arrHero[2] = new Wizard();

            arrHero[0].UseSkill();
            arrHero[1].UseSkill();
            arrHero[2].UseSkill();
        }
    }
}