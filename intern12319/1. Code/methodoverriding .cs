using System;

class LoadParent
    {
        public void Test()
        {
            Console.WriteLine("Parents test method");
        }
        public virtual void Show()  
        {
            Console.WriteLine("Parents SHOW Method");
        }
        public void Display()
        {
            Console.WriteLine("Parents display Method");
        }
    }	

class LoadChild : LoadParent
    {
        public void Test(int x)
        {
            Console.WriteLine("Childs test method");
        }
        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Test();      
            c.Test(10);     
            c.Show();       
            c.Display();    
            Console.ReadLine();
        }

    }
