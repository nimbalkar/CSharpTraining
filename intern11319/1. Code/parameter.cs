using System;

namespace program
{
class parameter
    {
      public void Test1() 
        {
            int n = 5;
            for (int i = 1; i <= 10; i++)
            Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
        }
      
      public void Test2(int n, int m)
        {
            for (int i = 1; i <= m; i++)
            Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
        }
     
      public string Test3()
        {
            string str = "tejas";
            str = str.ToUpper();
            return str;
        }
       
      public string Test4(string str)
        {
            str = str.ToUpper();
            return str;
        }

      static void Main(string[] args)
        {
            parameter P = new parameter();
            P.Test1();
            P.Test2(10, 10);
            string s1 = P.Test3();
            Console.WriteLine(s1);
            string s2 = P.Test4("tejasn");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
