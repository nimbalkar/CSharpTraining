using System;

namespace program
{
    class ifdemo
    {
        static void Main()
        {
            Console.WriteLine("Enter the 1st number");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int y=int.Parse(Console.ReadLine());
            if(x>y)
            {
                 Console.WriteLine("x is greater");
            }
            else
            {
                Console.WriteLine("Y is greater");
            }
           

        }
    }

}