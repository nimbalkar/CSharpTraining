using System;
namespace program

{
     class constructor
    {
     int x;  
     public constructor(int x)  
    {
     this.x = x;
    }
     public void Display()
    {
     Console.WriteLine("value of x is {0} ", x);
    }
     static void Main()
    {
     constructor p1 = new constructor(10);
     constructor p2 = new constructor(20);
     constructor p3 = new constructor(30);
     p1.Display(); 
     p2.Display();
     p3.Display();
     Console.ReadLine();
    } 
    }
}
