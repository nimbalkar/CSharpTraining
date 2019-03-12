using System;
 
 namespace program 
 {
  class Table 
   {
    static void Main()
    {
     Console.WriteLine("enter the value");
     int x=int.Parse(Console.ReadLine());
     if(x==0)
      return;
     for(int i=0;i<50;i++)
     Console.WriteLine("{0}*{1}={2}",x,i,x*i);
     }
  }
}