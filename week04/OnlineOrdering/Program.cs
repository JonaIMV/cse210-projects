using System;

class Program
{
    static void Main(string[] args)
    {
        // Create customers with addresses
        Address addressUSA = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", addressUSA);

        Address addressInternational = new Address("45 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Martin", addressInternational);

        // Create products
        Product product1 = new Product("USB Cable", "A100", 5.99, 3);
        Product product2 = new Product("Wireless Mouse", "B200", 15.50, 1);
        Product product3 = new Product("Notebook", "C300", 2.75, 5);
        Product product4 = new Product("Headphones", "D400", 25.00, 2);

        // Create order 1 for customer1 (USA)
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Create order 2 for customer2 (Canada)
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order 1
        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        // Display order 2
        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
