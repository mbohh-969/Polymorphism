using System;

namespace GamePolymorphism
{
    public class Knight : Hero
    {
        public int bonusArmor;

        public override void UseSkill()
        {
            base.UseSkill();
            Console.WriteLine("BONUS ARMOR = " + bonusArmor);
        }
    }
}