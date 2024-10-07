using System;

public interface IOutput
{
    void Show();
    void Show(string info);
}

public interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

public class MyArray : IOutput, IMath
{
    private int[] array;

    public MyArray(int[] array)
    {
        this.array = array;
    }

    public void Show()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }

    public int Max()
    {
        int max = array[0];
        foreach (int item in array)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    public int Min()
    {
        int min = array[0];
        foreach (int item in array)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }

    public float Avg()
    {
        int sum = 0;
        foreach (int item in array)
        {
            sum += item;
        }
        return (float)sum / array.Length;
    }

    public bool Search(int valueToSearch)
    {
        foreach (int item in array)
        {
            if (item == valueToSearch)
            {
                return true;
            }
        }
        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] numbers = { 10, 20, 30 };
        MyArray myArray = new MyArray(numbers);

        myArray.Show();
        myArray.Show("Просто інформаційне повідомлення");

        Console.WriteLine("Максимум: " + myArray.Max());
        Console.WriteLine("Мінімум: " + myArray.Min());
        Console.WriteLine("Середнє арифметичне: " + myArray.Avg());
        Console.WriteLine("Пошук значення 45: " + (myArray.Search(3) ? "Знайдено" : "Не знайдено"));
        Console.WriteLine("Пошук значення 20: " + (myArray.Search(10) ? "Знайдено" : "Не знайдено"));
    }
}
