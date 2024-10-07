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

public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

public class MyArray : IOutput, IMath, ISort
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

    public void SortAsc()
    {
        Array.Sort(array);
    }

    public void SortDesc()
    {
        Array.Sort(array);
        Array.Reverse(array);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] numbers = { 20, 10, 30, 60, 40, 50 };
        MyArray myArray = new MyArray(numbers);

        myArray.Show("Початковий масив:");

        myArray.SortAsc();
        myArray.Show("Масив після сортування за зростанням:");

        myArray.SortDesc();
        myArray.Show("Масив після сортування за спаданням:");

        myArray.SortByParam(true);
        myArray.Show("Масив після сортування за параметром (за зростанням):");

        myArray.SortByParam(false);
        myArray.Show("Масив після сортування за параметром (за спаданням):");
    }
}
