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
        }
    }
}