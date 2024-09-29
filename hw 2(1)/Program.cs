using System;
using System.Globalization;

public class Money
{
    private int wholePart;
    private int fractionalPart;

    public Money(int wholePart, int fractionalPart)
    {
        this.wholePart = wholePart;
        this.fractionalPart = fractionalPart;
    }

    public void ShowMoney()
    {
        Console.WriteLine($"{wholePart} гривень та {fractionalPart} копійок");
    }

    public void SetMoney(int wholePart, int fractionalPart)
    {
        this.wholePart = wholePart;
        this.fractionalPart = fractionalPart;
    }

    public int GetWholePart()
    {
        return wholePart;
    }

    public int GetFractionalPart()
    {
        return fractionalPart;
    }
}

public class Product : Money
{
    private string name;


    public Product(string name, int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
    {
        this.name = name;
    }


    public void ReducePrice(int reduceWhole, int reduceFractional)
    {
        int currentWhole = GetWholePart();
        int currentFractional = GetFractionalPart();


        currentFractional -= reduceFractional;
        if (currentFractional < 0)
        {
            currentWhole -= 1;
            currentFractional += 100;
        }


        currentWhole -= reduceWhole;


        SetMoney(currentWhole, currentFractional);
    }


    public void ShowProduct()
    {
        Console.WriteLine($"Продукт: {name}");
        ShowMoney();
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть назву продукту: ");
        string name = Console.ReadLine();

        Console.Write("Введіть цілу частину ціни (гривні): ");
        int wholePart = int.Parse(Console.ReadLine());

        Console.Write("Введіть дробову частину ціни (копійки): ");
        int fractionalPart = int.Parse(Console.ReadLine());

        Product product = new Product(name, wholePart, fractionalPart);
        product.ShowProduct();

        Console.Write("На скільки гривень зменшити ціну: ");
        int reduceWhole = int.Parse(Console.ReadLine());

        Console.Write("На скільки копійок зменшити ціну: ");
        int reduceFractional = int.Parse(Console.ReadLine());

        product.ReducePrice(reduceWhole, reduceFractional);
        Console.WriteLine("Після зменшення ціни:");
        product.ShowProduct();
    }
}
