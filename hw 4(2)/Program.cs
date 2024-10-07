using System;

public class City
{
    public string Name { get; set; }
    public int Population { get; set; }

    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }

    public static City operator +(City city, int increase)
    {
        city.Population += increase;
        return city;
    }

    public static City operator -(City city, int decrease)
    {
        city.Population -= decrease;
        return city;
    }

    public static bool operator ==(City city1, City city2)
    {
        return city1.Population == city2.Population;
    }

    public static bool operator !=(City city1, City city2)
    {
        return city1.Population != city2.Population;
    }

    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

     public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is City))
        {
            return false;
        }
        City city = obj as City;
        return this.Population == city.Population;
    }

    public override int GetHashCode()
    {
        return Population.GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        City city1 = new City("City A", 1000000);
        City city2 = new City("City B", 2000000);

        Console.WriteLine($"Населення до: {city1.Population}");
        city1 += 23000;
        Console.WriteLine($"Населення після збільшення: {city1.Population}");

        city2 -= 45000;
        Console.WriteLine($"Населення після зменшення: {city2.Population}");

        Console.WriteLine(city1 == city2 ? "Населення рівне" : "Населення різне");
        Console.WriteLine(city1 > city2 ? "Населення city1 більше" : "Населення city1 менше");
    }
}
