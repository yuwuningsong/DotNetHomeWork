using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;

namespace HomeWork8
{
    public partial class FormCreate : Form
    {
        public Order.Order Order { get; set; }
        public string Address { get; set; }
        private Product Product { get; set; }
        public int Num { get; set; }

        private Product[] products = new Product[3];
        public FormCreate()
        {
            InitializeComponent();

            products[0] = new Product()
            {
                Name = "AAA",
                Price = 2
            };
            products[1] = new Product()
            {
                Name = "BBB",
                Price = 3
            };
            products[2] = new Product()
            {
                Name = "CCC",
                Price = 5
            };

            Order = new Order.Order();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Product = products[comboProduct.SelectedIndex];

            Order.OrderDetails.Add(new OrderDetails(Product, Num));
            Order.Address = Address;

            this.Close();
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {
            textAddress.DataBindings.Add("Text", this, "Address");
            textNum.DataBindings.Add("Text", this, "Num");
        }
    }
}
