using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Product product1 = new Product(
            "Laptop",
            "P001",
            800,
            1
        );

        Product product2 = new Product(
            "Mouse",
            "P002",
            25,
            2
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address(
            "45 Avenida da Liberdade",
            "Luanda",
            "Luanda",
            "Angola"
        );

        Customer customer2 = new Customer(
            "Anderson Lima",
            address2
        );

        Product product3 = new Product(
            "Keyboard",
            "P003",
            50,
            1
        );

        Product product4 = new Product(
            "Monitor",
            "P004",
            200,
            2
        );

        Product product5 = new Product(
            "Headphones",
            "P005",
            75,
            1
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("--------------------");

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTOTAL PRICE: ${order1.GetTotalCost():F2}");

        Console.WriteLine("\n============================\n");


        Console.WriteLine("ORDER 2");
        Console.WriteLine("--------------------");

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTOTAL PRICE: ${order2.GetTotalCost():F2}");
    }
}