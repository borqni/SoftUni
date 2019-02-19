using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int len = int.Parse(Console.ReadLine());
        Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

        for (int i = 0; i < len; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string product = input[0];
            decimal price = decimal.Parse(input[1]);

            if (!shop.ContainsKey(product))
            {
                shop.Add(product, 0.0m);
            }
            shop[product] = price;
        }

        List<Customer> allCustomers = new List<Customer>();
        string line = Console.ReadLine();

        while (line != "end of clients")
        {
            string[] tokens = line.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Customer customer = new Customer();

            if (!shop.ContainsKey(tokens[1]))
            {
                line = Console.ReadLine();
                continue;
            }
            customer.Name = tokens[0];
            int quantity = int.Parse(tokens[2]);
            string product = tokens[1];
            decimal price = shop[product];
            customer.Quantity = quantity;
            customer.Price = price;
            customer.ShopList = new Dictionary<string, int>();

            if (allCustomers.Any(x => x.Name == customer.Name))
            {
                if (!allCustomers.First(x => x.Name == customer.Name).ShopList.ContainsKey(product))
                {
                    allCustomers.First(x => x.Name == customer.Name).ShopList.Add(product, quantity);
                    line = Console.ReadLine();
                    continue;
                }

                allCustomers.First(x => x.Name == customer.Name).ShopList[product] += quantity;
                line = Console.ReadLine();
                continue;
            }

            customer.ShopList.Add(product, quantity);
            allCustomers.Add(customer);
            line = Console.ReadLine();
        }

        decimal totalBill = 0.0m;

        foreach (var client in allCustomers.OrderBy(x => x.Name))
        {
            Console.WriteLine(client.Name);
            decimal bill = 0m;

            foreach (var product in client.ShopList.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-- {product.Key} - {product.Value}");
                bill += shop[product.Key] * product.Value;
            }

            Console.WriteLine($"Bill: {bill:f2}");
            totalBill += bill;
        }

        Console.WriteLine($"Total bill: {totalBill:f2}");
    }
}

class Customer
{
    public string Name { get; set; }
    public Dictionary<string, int> ShopList { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}