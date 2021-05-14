using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int OrderDetailID { get => Math.Abs(this.GetHashCode()); set { } }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int Num { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }

        public OrderDetails(Product product, int num)
        {
            this.Product = product;
            this.Num = num;
        }

        public OrderDetails() { }

        public override string ToString()
        {
            return Product + $"  数量：{Num}";
        }

        public override bool Equals(object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            if (orderDetails == null) return false;
            if (orderDetails.Product == null && this.Product == null) return true;
            if (orderDetails.Product != null && this.Product != null)
            {
                return (orderDetails.Product.Equals(this.Product)) && (orderDetails.Num == this.Num);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
