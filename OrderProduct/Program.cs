using System;
using System.Globalization;
using OrderProduct.Entities;
using OrderProduct.Entities.Enums;

namespace OrderProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string clientname = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter order data: ");
            Console.WriteLine("PeddingPayment/Processing/Shipped/Delivered ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client client = new Client(clientname, email, birthdate);
            Order order = new Order(DateTime.Now,status,client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name:");
                string productname = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantify: ");
                Product product = new Product(productname, price);
                int quantify = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantify,price,product);
                order.Additem(orderItem);
               
            
            
            }
            Console.WriteLine();
            Console.WriteLine("Order Sumary");
            Console.WriteLine(order);


        }
    }
}
