using System;

namespace GamePolymorphism
{
    public class Hero
    {
        public string? name;
        public int baseDamage;

        public virtual void UseSkill()
        {
            Console.WriteLine("NAME = " + name);
            Console.WriteLine("BASE DAMAGE = " + baseDamage);
        }
    }
}