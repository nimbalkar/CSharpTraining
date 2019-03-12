using System;
class TestMatrix
    {
       static void Main()
        {
            Matrix m1 = new Matrix(18, 16, 14, 12);
            Matrix m2 = new Matrix(10, 8, 6, 4);
            Matrix m3 = new Matrix(4, 3, 2, 1);
            Matrix m4 = (m1 + m2) + m3;
            Matrix m5 = (m1 - m2) - m3;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);
            Console.ReadLine();            
        }
    }	
