using System;
namespace program
{
 class Array
  {
    static void Main()
   {
     int[] arr = new int [10];
     int x = 0;
     for (int i = 0; i<10 ; i++)
     Console.Write(arr[i]+ " ");
     Console.WriteLine();
     for(int i = 0; i<10 ; i++)
      {
       x+=10;
       arr [i]=x;
      }
     foreach(int i in arr)
    Console.Write(i+ " ");
    Console.ReadLine();
    }
  }
}
