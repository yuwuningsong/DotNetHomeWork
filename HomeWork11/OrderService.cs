using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.Entity;
using HomeWork11;

namespace Order
{
    public class OrderService
    {
        public List<Order> Orders { get; set; }

        public OrderService()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            if (order == null) return;
            using (var context = new OrderContext())
            {
                if (this.FindOrder(order) != null) return;
                context.Orders.Add(order);
                context.SaveChanges();
                Orders.Add(order);
            }
        }

        public void DeleteOrder(Order order)
        {
            if (!Orders.Remove(FindOrder(order)))
            {
                throw new Exception("该订单不存在！");
            }
            using (var context = new OrderContext())
            {
                var orderFound = context.Orders.Include(o => o.OrderDetails).FirstOrDefault(od => od.OrderID == order.OrderID);
                if (orderFound != null)
                {
                    context.Orders.Remove(orderFound);
                    context.SaveChanges();
                }
            }
        }

        // 查询列表中某订单
        public Order FindOrder(Order order)
        {
            if (order == null) return null;
            using (var context = new OrderContext())
            {
                var orderFound = context.Orders.SingleOrDefault(o => o.OrderID == order.OrderID);
                if (orderFound != null) return orderFound;
            }
            return null;
        }

        // 修改订单配送地址
        public void ChangeOrderAddress(Order order, string orderAddress)
        {
            using (var context = new OrderContext())
            {
                FindOrder(order).Address = orderAddress;
                context.SaveChanges();
            }
        }

        public void ChangeOrderCustomer(Order order, string customerName)
        {
            using (var context = new OrderContext())
            {
                FindOrder(order).Customer = new Customer(customerName);
                context.SaveChanges();
            }
        }

        public List<Order> FindOrder(Product product)
        {
            using (var context = new OrderContext())
            {
                var query = context.OrderDetails.Where(oD => oD.Product.Name == product.Name);
                if (query != null)
                {
                    List<Order> orders = new List<Order>();
                    foreach(var orderDetail in query)
                    {
                        orders.Add(orderDetail.Order);
                    }
                    return orders;
                }
                return null;
            }
        }

        public List<Order> FindOrder(Customer customer)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders.Where(o => o.Customer.Name == customer.Name);
                if (query != null)
                {
                    return query.ToList<Order>();
                }
                return null;
            }
        }

        public IEnumerable<Order> FindOrder(float totalPrice)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders.Where(o => o.TotalPrice == totalPrice);
                if (query != null)
                {
                    return query.ToList<Order>();
                }
                return null;
            }
        }

        public void Export(List<Order> orders, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        // 导入xml文件
        public void Import(string fileName, bool isOverride = true)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> orders = new List<Order>();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            for (int i = 0; i < orders.Count; i++)
            {
                AddOrder(orders[i]);
            }
        }
    }
}
