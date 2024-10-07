using System;

public class CreditCard
{
    public string CVC { get; set; }
    public double Balance { get; set; }

    public CreditCard(string cvc, double balance)
    {
        CVC = cvc;
        Balance = balance;
    }

    public static CreditCard operator +(CreditCard card, double amount)
    {
        card.Balance += amount;
        return card;
    }

    public static CreditCard operator -(CreditCard card, double amount)
    {
        card.Balance -= amount;
        return card;
    }

    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        return card1.CVC == card2.CVC;
    }

    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return card1.CVC != card2.CVC;
    }

    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.Balance > card2.Balance;
    }

    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.Balance < card2.Balance;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is CreditCard))
        {
            return false;
        }
        CreditCard card = obj as CreditCard;
        return this.CVC == card.CVC;
    }

    public override int GetHashCode()
    {
        return CVC.GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        CreditCard card1 = new CreditCard("111", 5345);
        CreditCard card2 = new CreditCard("111", 3231);

        Console.WriteLine($"Баланс до: {card1.Balance}");
        card1 += 1000;
        Console.WriteLine($"Баланс після збільшення: {card1.Balance}");

        card2 -= 500;
        Console.WriteLine($"Баланс після зменшення: {card2.Balance}");

        Console.WriteLine(card1 == card2 ? "CVC однакові" : "CVC різні");
        Console.WriteLine(card1 > card2 ? "Баланс card1 більший" : "Баланс card1 менший");
    }
}
