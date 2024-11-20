using System;

namespace CalculatorApps
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Не можна ділити на нуль.");
            return a / b;
        }
        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);
        public double SquareRoot(double a)
        {
            if (a < 0) throw new ArgumentException("Не можна обчислити квадратний корінь від від'ємного числа.");
            return Math.Sqrt(a);
        }

        public double Approximate(double value, int decimalPlaces)
        {
            return Math.Round(value, decimalPlaces);
        }

        // Обчислення факторіала
        public long Factorial(int number)
        {
            if (number < 0) throw new ArgumentException("Не можна обчислити факторіал для від'ємних чисел.");
            if (number == 0 || number == 1) return 1;

            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Обчислення числа Пі за формулою Лейбніца
        public double ApproximatePiLeibniz(int iterations)
        {
            if (iterations <= 0) throw new ArgumentException("Кількість ітерацій має бути більше нуля.");

            double pi = 0;
            for (int i = 0; i < iterations; i++)
            {
                // Формула: π = 4 * Σ((-1)^i / (2i + 1))
                pi += Math.Pow(-1, i) / (2.0 * i + 1.0);
            }

            return 4 * pi;
        }
    }
}
