using System;
using System.Collections.Generic;

public interface IShopper
{
    void AddToCart(string item);
}

public class Customer : IShopper
{
    public string Name { get; set; }
    public List<string> ShoppingCart { get; set; }

    public Customer(string name)
    {
        Name = name;
        ShoppingCart = new List<string>();
    }

    public void AddToCart(string item)
    {
        ShoppingCart.Add(item);
        Console.WriteLine($"{item} було додано в кошик {Name}.");
    }

    public void ViewCart()
    {
        Console.WriteLine($"Кошик {Name}:");
        foreach (var item in ShoppingCart)
        {
            Console.WriteLine($"- {item}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Олексiй");

        customer.AddToCart("Ноутбук");
        customer.AddToCart("Мобiльний телефон");
        customer.AddToCart("Навушники");
        customer.ViewCart();
      
        Console.WriteLine("\nPress any key to complete...");
        Console.ReadKey();

    }
}
