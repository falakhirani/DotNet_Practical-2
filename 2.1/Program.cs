using System;

namespace Numb
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = 2;
            int d = 3;

            double e = 5;
            double f = 4;
            double g = 2;

            decimal h = 1.0M;
            decimal i = 3.0M;

            Pro.add(a, b);
            Pro.sub(a, b);
            Pro.mul(a, b);
            Pro.div(a, b);
            Pro.complex(a, b, c);
            Pro.complex2(a, b, c, d);
            Pro.findMinMax();
            Pro.dbAdd(e, f, g);
            Pro.findMinMaxDb();
            Pro.findMinMaxDec();
            Pro.decOp(h, i);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area : {area}");
        }


    }

    static class Pro
    {

        public static void add(int a, int b)
        {
            Console.WriteLine("Output of add...");
            int c = a + b;
            Console.WriteLine(c);
        }

        public static void sub(int a, int b)
        {
            Console.WriteLine("Output of sub...");
            int d = a - b;
            Console.WriteLine(d);
        }

        public static void mul(int a, int b)
        {
            Console.WriteLine("Output of mul...");
            int e = a * b;
            Console.WriteLine(e);
        }

        public static void div(int a, int b)
        {
            Console.WriteLine("Output of div...");
            int f = a / b;
            Console.WriteLine(f);
        }

        public static void complex(int a, int b, int c)
        {
            Console.WriteLine("Output of complex...");
            int g = a + b * c;
            Console.WriteLine(g);
        }

        public static void complex2(int a, int b, int c, int d)
        {
            Console.WriteLine("Output of complex2...");
            int e = (a + b) / c;
            int f = (a + b) % c;
            Console.WriteLine($"quotient : {e}");
            Console.WriteLine($"remainder : {f}");
        }

        public static void findMinMax()
        {
            Console.WriteLine("Output of findMinMax...");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
        }

        public static void dbAdd(double a, double b, double c)
        {
            Console.WriteLine("Output of dbAdd...");
            double d = (a + b) / c;
            Console.WriteLine(d);
        }

        public static void findMinMaxDb()
        {
            Console.WriteLine("Output of findMinMaxDb...");
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
        }

        public static void findMinMaxDec()
        {
            Console.WriteLine("Output of findMinMaxDec...");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
        }

        public static void decOp(decimal a, decimal b)
        {
            Console.WriteLine("Output of decOp...");
            Console.WriteLine(a / b);
        }
    }
}
