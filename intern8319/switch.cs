using System;

namespace program
{
    class Switch
    {
        static void Main()
        {
            Console.WriteLine("Enter the 1-3 number");
            int no=int.Parse(Console.ReadLine());
            switch(no)
            {
                case 1:
                Console.WriteLine("student 1");
                break;

                case 2:
                Console.WriteLine("student 2");
                break;

                case 3:
                Console.WriteLine("student 3");
                break;

                default:
                Console.WriteLine("Outoff number");
                break;

            }
        }
    }
}