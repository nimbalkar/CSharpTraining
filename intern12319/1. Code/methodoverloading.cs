using System;

    class LoadDemo
    {
        public void show()
        {
            Console.WriteLine();
        }
        public void show(string s)
        {
            Console.WriteLine(s);
        }
        public void show(int x)
        {
            Console.WriteLine(x);
        }
        public void show(string s, int x)
        {
            Console.WriteLine(s,x);
        }
        public void show(int x, string s)
        {
            Console.WriteLine(s);
        }
        static void Main()
        {
            LoadDemo d = new LoadDemo();
            d.show();
            d.show("show");
            d.show(10);
            d.show("hello", 10);
            d.show(10, "hello");           
        }
    }        
