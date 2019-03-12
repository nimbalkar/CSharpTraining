using System;
        
    class LoadCon
    {
        int x;
        public LoadCon()
        {
            this.x = 10;
        }
        public LoadCon(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine("value of x is : {0}", x);
        }
        static void Main()
        {
            LoadCon c1 = new LoadCon();
            LoadCon c2 = new LoadCon(50);
            c1.Display();
            c2.Display();
            Console.ReadLine();
        }
    }
