using System;

namespace Calculator
{
    public static class Calculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return a / b;
        }
        public static double Square(double a) => a * a;
        public static double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Невозможно извлечь корень из отрицательного числа.");
            return Math.Sqrt(a);
        }
    }
}