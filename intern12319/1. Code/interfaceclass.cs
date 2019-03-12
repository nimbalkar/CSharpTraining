class ImplClass : Inter1,Inter2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x-y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main()
        {
            ImplClass c = new ImplClass();
            c.Add(10, 20); c.Sub(20, 10);
            c.Mul(12, 12); c.Div(24, 12);
            Console.ReadLine();
        }
    }
