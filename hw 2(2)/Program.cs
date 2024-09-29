using System;
using System.Globalization;

public class MusicalInstrument
{
    protected string name;
    protected string description;
    protected string history;

    public MusicalInstrument(string name, string description, string history)
    {
        this.name = name;
        this.description = description;
        this.history = history;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Інструмент видає звук.");
    }

    public void Show()
    {
        Console.WriteLine($"Назва інструменту: {name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Опис інструменту: {description}");
    }

    public void History()
    {
        Console.WriteLine($"Історія інструменту: {history}");
    }
}

public class Violin : MusicalInstrument
{
    public Violin() : base("Скрипка", "Струнно-смичковий музичний інструмент.", "Скрипка з'явилася в XVI столітті.")
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Скрипка видає ніжний та мелодійний звук.");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone() : base("Тромбон", "Мідний духовий інструмент.", "Тромбон існує з XV століття.")
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Тромбон видає глибокий та потужний звук.");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Укулеле", "Гавайська чотириструнна гітара.", "Укулеле виникло на Гаваях у XIX столітті.")
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Укулеле видає веселий і легкий звук.");
    }
}

public class Cello : MusicalInstrument
{
    public Cello() : base("Віолончель", "Великий струнно-смичковий інструмент.", "Віолончель виникла у XVII столітті.")
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Віолончель видає глибокий та насичений звук.");
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Виберіть інструмент (1: Скрипка, 2: Тромбон, 3: Укулеле, 4: Віолончель):");
        int choice = int.Parse(Console.ReadLine());

        MusicalInstrument instrument = null;

        switch (choice)
        {
            case 1:
                instrument = new Violin();
                break;
            case 2:
                instrument = new Trombone();
                break;
            case 3:
                instrument = new Ukulele();
                break;
            case 4:
                instrument = new Cello();
                break;
            default:
                Console.WriteLine("Невірний вибір!");
                return;
        }

        instrument.Show();
        instrument.Sound();
        instrument.Desc();
        instrument.History();
    }
}
