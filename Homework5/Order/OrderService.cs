using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (FindOrder(order) == null)
            {
                orders.Add(order);
            }
        }

        public void DeleteOrder(Order order)
        {
            if (!orders.Remove(FindOrder(order)))
            {
                throw new Exception("该订单不存在！");
            }
        }

        // 查询列表中某订单
        public Order FindOrder(Order order)
        {
            var orderNeed = orders.Where(ord => ord.Equals(order));
            if (orderNeed.Count() == 0) return null;
            Order[] ordersNeed = orderNeed.ToArray();
            if (ordersNeed.Length > 1) throw new Exception("存在相同订单！");
            return ordersNeed[0];
        }

        // 修改订单配送地址
        public void ChangeOrderAddress(Order order, string orderAddress)
        {
            FindOrder(order).Address = orderAddress;
        }

        public void ChangeOrderCustomer(Order order, string customerName)
        {
            FindOrder(order).Customer = new Customer(customerName);
        }

        public IEnumerable<Order> FindOrder(int orderID)
        {
            return orders.Where(order => order.OrderID == orderID);
        }

        public IEnumerable<Order> FindOrder(Product product)
        {
            return orders.Where(order => order.ContainProduct(product));
        }

        public IEnumerable<Order> FindOrder(Customer customer)
        {
            return orders.Where(order => order.Customer.Equals(customer));
        }

        public IEnumerable<Order> FindOrder(float totalPrice)
        {
            return orders.Where(order => order.TotalPrice == totalPrice);
        }

    }
}
