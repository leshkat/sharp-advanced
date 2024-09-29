using System;

public class Calculator
{
    public double Add(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Ділення на нуль неможливе.");
        }
        return a / b;
    }

    public double SquareRoot(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Квадратний корінь з від'ємного числа не визначений.");
        }
        return Math.Sqrt(a);
    }

    public double Power(double a, double exponent) => Math.Pow(a, exponent);
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Calculator calc = new Calculator();

        while (true)
        {
            Console.WriteLine("Виберіть операцію:");
            Console.WriteLine("1. Додавання");
            Console.WriteLine("2. Віднімання");
            Console.WriteLine("3. Множення");
            Console.WriteLine("4. Ділення");
            Console.WriteLine("5. Квадратний корінь");
            Console.WriteLine("6. Піднесення до степеня");
            Console.WriteLine("0. Вихід");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if (choice == "0")
                break;

            double a, b;

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть перше число: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть друге число: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: " + calc.Add(a, b));
                        break;

                    case "2":
                        Console.Write("Введіть перше число: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть друге число: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: " + calc.Subtract(a, b));
                        break;

                    case "3":
                        Console.Write("Введіть перше число: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть друге число: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: " + calc.Multiply(a, b));
                        break;

                    case "4":
                        Console.Write("Введіть перше число: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть друге число: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: " + calc.Divide(a, b));
                        break;

                    case "5":
                        Console.Write("Введіть число: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Квадратний корінь: " + calc.SquareRoot(a));
                        break;

                    case "6":
                        Console.Write("Введіть число: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть степінь: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: " + calc.Power(a, b));
                        break;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }

            Console.WriteLine();
        }
    }
}
