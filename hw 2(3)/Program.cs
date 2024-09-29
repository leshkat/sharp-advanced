using System;
using System.Globalization;

public struct DecimalNumber
{
    private int number;

    public DecimalNumber(int number)
    {
        this.number = number;
    }

    public string ToBinary()
    {
        return Convert.ToString(number, 2);
    }

    public string ToOctal()
    {
        return Convert.ToString(number, 8);
    }

    public string ToHexadecimal()
    {
        return Convert.ToString(number, 16).ToUpper();
    }

    public void ShowNumber()
    {
        Console.WriteLine($"Десяткове число: {number}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть десяткове число: ");
        int number = int.Parse(Console.ReadLine());

        DecimalNumber decimalNumber = new DecimalNumber(number);

        decimalNumber.ShowNumber();
        Console.WriteLine($"Двійкова система: {decimalNumber.ToBinary()}");
        Console.WriteLine($"Вісімкова система: {decimalNumber.ToOctal()}");
        Console.WriteLine($"Шістнадцяткова система: {decimalNumber.ToHexadecimal()}");
    }
}
