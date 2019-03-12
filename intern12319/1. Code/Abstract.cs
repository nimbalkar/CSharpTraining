using System;
abstract class AbsParent
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void sub(int x, int y)
        {
           Console.WriteLine(x - y);
        }
        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);

    }
    
    class AbsChild:AbsParent
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            c.add(10, 20);c.sub(10, 20);
            c.mul(2, 3);c.div(8, 2);
            Console.ReadLine();
        }
    }
