using System;

public interface IOutput
{
    void Show();
    void Show(string info);
}

public class MyArray : IOutput
{
    private int[] array;

    public MyArray(int[] array)
    {
        this.array = array;
    }

    public void Show()
    {
        Console.WriteLine("Елементи масиву: ");
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
}

public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] numbers = { 10, 20, 30};
        MyArray myArray = new MyArray(numbers);

        myArray.Show();
        myArray.Show("Просто інформаційне повідомлення");
    }
}
