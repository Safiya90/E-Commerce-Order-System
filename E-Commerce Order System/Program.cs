using System.Diagnostics;

namespace E_Commerce_Order_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("tap", 150, 3);
            Product p2 = new Product("light", 25, 12);
            Product p3 = new Product();
            Order order = new Order();
            order.Add(p1);
            order.Add(p2);
            order.Add(p3);

            Console.WriteLine($"Total Order Cost: {order.Total()}");

        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product()
        {
            Name = "Laptop";
            Price = 199;
            Quantity = 20;

        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double CalculateTotal()
        {
            return Price * Quantity;
        }
        public int CalculateTotal(int Price, int Quantity)
        {
            return Price*Quantity;
        }
    }
    class Order
    {
        private Product[] products;
        private int count;

        public Order()
        {
            products = new Product[100];
            count = 0;
        }
        public void Add(Product product)
        {
            if (count < products.Length)
            {
                products[count++] = product;
            }
        }
        public double Total()
        {
            double total = 0;
            for (int i = 0; i < count; i++)
            {
                total += products[i].CalculateTotal();
            }
            return total;
        }

    }

}
