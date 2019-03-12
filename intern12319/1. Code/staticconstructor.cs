using System;

namespace program
{
    class StaticCon
    {
        static StaticCon()
        {
            Console.WriteLine("Static constructure gets called");
        }
        public StaticCon()
        {
            Console.WriteLine("instance constructure gets called");
        }
        static void Main()
        {
            Console.WriteLine("main method is executed");
            StaticCon s1 = new StaticCon();
            StaticCon s2 = new StaticCon();
            Console.ReadLine();
        }
    }
}