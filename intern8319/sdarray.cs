using System;
namespace program
{
  class SDArray
   {
    static void Main()
    {
     int[] arr={33,56,34,22,78,92,56,78,94,55};
     for(int k=0;k<arr.Length; k++);
     Console.WriteLine(arr[k] + " ");
     Console.WriteLine();
     Array.Sort (arr); 	
     foreach (int i in arr)
     Console.Write(i+" ");
     Console.WriteLine();
     Array.Reverse(arr);
     foreach(int i in arr)
     Console.Write(i+ " ");
     Console.WriteLine();
     int[] brr = new int[10];
     Array.Copy (arr, brr,5);
     foreach(int i in brr)
     Console.Write (i+" ");
     Console.WriteLine();
    }
  }
}


