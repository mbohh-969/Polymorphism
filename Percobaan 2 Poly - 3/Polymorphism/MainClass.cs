using System;

namespace GamePolymorphism
{
    public class MainClass
    {
        public static void Main(String[] args)
        {
            
            Knight k = new Knight();
            k.baseDamage = 100;
            k.name = "Arthur";
            k.bonusArmor = 50;

            Wizard w = new Wizard();
            w.baseDamage = 80;
            w.name = "Merlin";
            w.bonusMagic = 150;

            CalculateTotalDamage(k);
            CalculateTotalDamage(w);
        

           
    }

    public static void CalculateTotalDamage(Hero h)
        {
            if (h is Knight)
            {
                Knight k = (Knight)h;
                int total = k.baseDamage + k.bonusArmor;
                Console.WriteLine("Total Damage Knight = " + total);

            }
            else if (h is Wizard)
            {
                Wizard w = (Wizard)h;
                int total = w.baseDamage + w.bonusMagic;
                Console.WriteLine("Total Damage Wizard = " + total);
            }
    
            
        }
    }
}