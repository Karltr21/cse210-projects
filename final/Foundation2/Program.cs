using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // This is my lists and other assigned variables
        Address address1 = new Address("123 Mcdonalds", "Kuna", "Idaho", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        
        List<string> productNames = new List<string> 
        {   "Laptop",
            "Mouse",
            "Desk Chair",
            "Keyboard",
            "Monitor" 
            };
        List<string> productIds = new List<string> 
        {   
            "P1001",
            "P1002",
            "P2001",
            "P2002",
            "P2003" 
        };
        List<int> productPrices = new List<int> 
        { 
            899,
            20,
            130,
            50,
            21 
        };

        //This is where I call my orders and have the assigned customer get the random products
        Order order1 = new Order(customer1);
        for (int i = 0; i < 2; i++)
        {
            int x = random.Next(productNames.Count);
            order1.AddProduct(new Products(productNames[x], productIds[x], productPrices[x], random.Next(1, 4)));
        }

        Order order2 = new Order(customer2);
        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(productNames.Count);
            order2.AddProduct(new Products(productNames[index], productIds[index], productPrices[index], random.Next(1, 4)));
        }

        // order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        // order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");
        
    }
}