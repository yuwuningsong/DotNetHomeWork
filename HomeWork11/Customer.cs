using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Customer
    {
        [Key]
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public Customer() { }

        public override string ToString()
        {
            return $"客户：{Name}";
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            if (customer == null) return false;
            return customer.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
