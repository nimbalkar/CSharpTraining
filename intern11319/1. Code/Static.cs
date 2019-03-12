using System;

namespace program
{
    class Staticvars
    {
        int x;
        static int y=100;
        const float pi=3.14f;
        readonly bool flag;

        public Staticvars(int x,bool flag )
        {
            this.x=x;
            this.flag=flag;
        }
        static void Main()
        {
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Staticvars s1=new Staticvars(100,true);
            Staticvars s2=new Staticvars(50,false);
            Console.WriteLine(s1.x+""+s2.x);
            Console.WriteLine(s1.flag+""+s2.flag);
            Console.ReadLine();

        }
    }
}
