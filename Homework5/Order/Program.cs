using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OrderService orderService = new OrderService();

                Product[] products = new Product[]
                {
                new Product(){ Name = "A", Price = 1f },
                new Product(){ Name = "B", Price = 2f },
                new Product(){ Name = "C", Price = 3f }
                };

                OrderDetails[] orderDetails = new OrderDetails[]
                {
                new OrderDetails(products[0], 3),
                new OrderDetails(products[1], 5),
                new OrderDetails(products[2], 4)
                };

                Order[] orders = new Order[3];

                orders[0] = new Order()
                {
                    OrderDetails =
                    {
                        orderDetails[0],
                        orderDetails[1]
                    },
                    Customer = new Customer("AAA"),
                    Address = "武汉大学"

                };

                orders[1] = new Order()
                {
                    OrderDetails =
                    {
                        orderDetails[1]
                    },
                    Customer = new Customer("BBB"),
                    Address = "武汉大学"

                };

                orderService.AddOrder(orders[0]);
                orderService.AddOrder(orders[1]);

                orderService.Orders.Sort();

                foreach (Order order in orderService.FindOrder(new Customer("AAA")))
                {
                    Console.WriteLine(order);
                }

                orderService.Orders.Sort((order1, order2) => order1.OrderDetails.Count - order2.OrderDetails.Count);

                foreach (Order order in orderService.FindOrder(new Product() { Name = "B", Price = 2f }))
                {
                    Console.WriteLine(order);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            
        }
    }
}
