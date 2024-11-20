using System;

namespace CalculatorApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var calculator = new Calculator();

            Console.WriteLine("Введіть перше число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Додавання: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Віднімання: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Множення: {calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Ділення: {calculator.Divide(num1, num2)}");
            Console.WriteLine($"Піднесення до степеня: {calculator.Power(num1, num2)}");
            Console.WriteLine($"Квадратний корінь з першого числа: {calculator.SquareRoot(num1)}");

            Console.WriteLine("Введіть число для обчислення факторіала:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факторіал числа {num}: {calculator.Factorial(num)}");

            Console.WriteLine("Введіть кількість ітерацій для обчислення Пі (формула Лейбніца):");
            int iterations = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Приблизне значення Пі: {calculator.ApproximatePiLeibniz(iterations)}");
        }
    }
}
