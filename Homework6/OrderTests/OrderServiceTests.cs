using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        private Order order = new Order()
        {
            OrderDetails =
                    {
                        new OrderDetails(new Product() { Name = "A", Price = 1}, 2)
                    },
            Customer = new Customer("AAA"),
            Address = "武汉大学"
        };

        [TestMethod()]
        public void AddOrderTest1()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            List<Order> orders = new List<Order>();
            orders.Add(order);

            Assert.AreEqual(orders[0], orderService.Orders[0]);
        }

        [TestMethod()]
        public void AddOrderTest2()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(null);
            Assert.AreEqual(orderService.Orders.Count, 0);
        }

        [TestMethod()]
        public void AddOrderTest3()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            orderService.AddOrder(order);
            Assert.AreEqual(orderService.Orders.Count, 1);
            Assert.AreEqual(orderService.Orders[0], order);
        }

        [TestMethod()]
        public void DeleteOrderTest1()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            orderService.DeleteOrder(order);
            Assert.AreEqual(orderService.Orders.Count, 0);
        }

        [TestMethod()]
        public void DeleteOrderTest2()
        {
            try
            {
                OrderService orderService = new OrderService();
                orderService.DeleteOrder(null);
            }
            catch (Exception ex)
            {
                if (ex.Message != "该订单不存在！") Assert.Fail();
            }
        }

        [TestMethod()]
        public void FindOrderTest1()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Order orderFind =  orderService.FindOrder(order);
            Assert.AreSame(order, orderFind);
        }

        [TestMethod()]
        public void ChangeOrderAddressTest()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            orderService.ChangeOrderAddress(order, "武汉理工大学");
            Assert.AreEqual(orderService.Orders[0].Address, "武汉理工大学");
        }

        [TestMethod()]
        public void ChangeOrderCustomerTest()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            orderService.ChangeOrderCustomer(order, "BBB");
            Assert.AreEqual(orderService.Orders[0].Customer.Name, "BBB");
        }

        [TestMethod()]
        public void FindOrderTest2()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Order[] orders = orderService.FindOrder(order.OrderID).ToArray();
            Assert.AreEqual(orders.Length, 1);
            Assert.AreSame(orders[0], order);
        }

        [TestMethod()]
        public void FindOrderTest3()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Order[] orders = orderService.FindOrder(order.OrderDetails[0].Product).ToArray();
            Assert.AreEqual(orders.Length, 1);
            Assert.AreSame(orders[0], order);
        }

        [TestMethod()]
        public void FindOrderTest4()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Order[] orders = orderService.FindOrder(order.Customer).ToArray();
            Assert.AreEqual(orders.Length, 1);
            Assert.AreSame(orders[0], order);
        }

        [TestMethod()]
        public void FindOrderTest5()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Order[] orders = orderService.FindOrder(order.TotalPrice).ToArray();
            Assert.AreEqual(orders.Length, 1);
            Assert.AreSame(orders[0], order);
        }
    }
}