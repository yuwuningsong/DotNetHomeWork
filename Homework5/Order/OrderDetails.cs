using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class OrderDetails
    {
        public Product Product { get; set; }
        public int Num { get; set; }

        public OrderDetails(Product product, int num)
        {
            this.Product = product;
            this.Num = num;
        }

        public override string ToString()
        {
            return Product + $"  数量：{Num}";
        }

        public override bool Equals(object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            return (orderDetails.Product.Equals(this.Product)) && (orderDetails.Num == this.Num);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
