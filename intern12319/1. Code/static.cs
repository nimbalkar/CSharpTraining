using System;

namespace program
{
     class StaticMets
    {
        int x = 50;
        static int y = 100;
        public static void Add()
        {
            StaticMets obj = new StaticMets();
            Console.WriteLine(obj.x + y);
        }
    static void Main()
        {
            StaticMets.Add();
            Console.ReadLine();
        }
    }
}