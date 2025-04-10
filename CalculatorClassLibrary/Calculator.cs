using System;
using System.Diagnostics;

namespace Calculator
{
    public static class Calculator
    {
        public const double epsilon = 1E-8;
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

            double root = a;  // Начальное приближение
            while (Math.Abs(root * root - a) > epsilon)  // Пока точность не достигнута
            {
                root = (root + a / root) / 2;  // Метод Герона
            }
            return Math.Round(root, 8);

            // return Math.Sqrt(number);
        }

        public static int StringSum(string s) => s.ToArray().Where(x => char.IsDigit(x)).Select(x => (int)(x - '0')).Sum();
    }
}