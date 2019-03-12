using System;
namespace program
{
    class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("Class2 constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine("method 3");
        }
        static void Main()
        {
            Class2 obj=new Class2();
            obj.Test1;
            obj.Test2;
            obj.Test3;
            Console.ReadLine();
        } 
    }
}  