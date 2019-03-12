using System;
namespace program
{
    class ConDemo
    {
      public ConDemo()
     {
      Console.Write("Constructor is called");  
     }
      public void Demo()
     {
      Console.Write("Method is Called");
     }
     static void Main()
     {
       ConDemo cd1=new ConDemo();
        ConDemo cd2=new ConDemo();
         ConDemo cd3=cd1;
         cd1.Demo();
         cd2.Demo();
         cd3.Demo();
         Console.ReadLine();
     }
    }
}

     