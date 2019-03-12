using System;

class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;this.b = b;this.c=c;this.d=d;
        }
        public static Matrix operator +(Matrix m1,Matrix m2)
        {
            Matrix obj = new Matrix(m1.a + m2.a, m1.b + m2.b,m1.c + m2.c, m1.d + m2.d);
            return obj;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix obj = new Matrix(m1.a - m2.a, m1.b - m2.b, m1.c - m2.c, m1.d - m2.d);
            return obj;
        }
        public override string ToString()
        {
            return a+ " "+ b + "\n" + c + " " + d +"\n";
        }
    }


