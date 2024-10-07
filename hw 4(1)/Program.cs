using System;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public static Employee operator +(Employee emp, double amount)
    {
        emp.Salary += amount;
        return emp;
    }

    public static Employee operator -(Employee emp, double amount)
    {
        emp.Salary -= amount;
        return emp;
    }

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Salary == emp2.Salary;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return emp1.Salary != emp2.Salary;
    }

    public static bool operator >(Employee emp1, Employee emp2)
    {
        return emp1.Salary > emp2.Salary;
    }

    public static bool operator <(Employee emp1, Employee emp2)
    {
        return emp1.Salary < emp2.Salary;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Employee))
        {
            return false;
        }
        Employee emp = obj as Employee;
        return this.Salary == emp.Salary;
    }

    public override int GetHashCode()
    {
        return Salary.GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Employee emp1 = new Employee("Anna", 10755);
        Employee emp2 = new Employee("Max", 11235);

        Console.WriteLine($"Зарплата до: {emp1.Salary}");
        emp1 += 1200;
        Console.WriteLine($"Зарплата після збільшення: {emp1.Salary}");

        emp2 -= 850;
        Console.WriteLine($"Зарплата після зменшення: {emp2.Salary}");

        Console.WriteLine(emp1 == emp2 ? "Зарплати рівні" : "Зарплати різні");
        Console.WriteLine(emp1 > emp2 ? "Зарплата emp1 більша" : "Зарплата emp1 менша");
    }
}
