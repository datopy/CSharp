using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMathHelper
{
    public static class CustomMath
    {

        public static double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }
        public static double Substract(double a, double b)
        {
            double result = a - b;
            return result;
        }
        public static double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }
        public static double Divide(double a, double b)
        {
            double result = 0;

            if (b == 0)
            {
                Console.WriteLine("Zero Division Error");
            }
            else
            {
                result = a / b;
            }

            return result;
        }
        public static double Pow(double a, double b)
        {
            double result = a;

            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }
        public static int Sqrt(int a)
        {
            int result = 1;
            int count = 0;

            while (true)
            {
                count += 1;
                result = (a / result + result) / 2;
                if (count == a + 1)
                {
                    break;
                }
            }

            return result;
        }

    }
}
