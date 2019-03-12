using System;

namespace program
{
    class Params
      {
         public void math1(int a,int b,ref int c, ref int d)
        {
            c = a + b;
            d = a * b;
        }
         public void math2(int a,int b,out int c,out int d)
        {
            c = a + b;
            d = a * b;
        }
         public void AddNum(int x,int y=50,int z=25)
        {
            Console.WriteLine(x + y + z);
        }
         static void Main(string[] args)
        {
            Params p=new Params();

            int x=0,y=0;
            p.math1(100,50,ref x,ref y);
            Console.WriteLine(x + " " + y);

            int m,n;
            p.math2(100,25,out m,out n);
            Console.WriteLine(m + "" + n);
           
            p.AddNum(50);
            p.AddNum(100,100);
            p.AddNum(100,z:100);
            p.AddNum(100,100,100);
            Console.ReadLine();   

        }
    }
}
