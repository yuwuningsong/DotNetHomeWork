using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"客户：{Name}";
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            return customer.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
