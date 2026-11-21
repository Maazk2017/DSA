using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_Basics
{
    internal class Questions
    {
        public void printNTOOne(int n)
        {
            if (n < 1)
            {
                return;
            }
            Console.Write(n + " ");
            n--;
            printNTOOne(n);
            // printNTOOne(n-1); 
        }

        public void printOneToN(int n)
        {
            if (n < 1) return;
            printOneToN(n - 1);
            Console.Write(n + " ");
        }

        public void DecInc(int n)
        {
            if (n == 0) return;
            Console.WriteLine(n + " ");
            DecInc(n - 1);
            Console.WriteLine(n + " ");
        }

        public int factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * factorial(n - 1);
        }

        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            double call = MyPow(x, n / 2);
            if (n % 2 == 0)
            {
                return call * call;
            }
            else
            {
                return call * call * x;
            }
        }

        public int Fib(int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 0;
            return Fib(n - 1) + Fib(n - 2);
        }

        public int countWays(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return countWays(n - 1) + countWays(n - 2);
        }


    }
}
