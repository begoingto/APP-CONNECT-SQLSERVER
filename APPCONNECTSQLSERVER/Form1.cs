using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace APPCONNECTSQLSERVER
{
    public partial class Form1 : Form
    {
        private OrderDetail detail = new OrderDetail();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productControll1.Visible = false;
            this.listProduct1.Visible = false;
            this.manageProduct1.Visible = false;
            this.orderDetail1.Visible = false;
            Login login = new Login();
            login.ShowDialog(this);
            Product.Rows = detail.Rows;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DataConnect.DataCon = null;
            new Login().ShowDialog(this);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            new ListEmployees().ShowDialog(this);
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            new Lottery().ShowDialog(this);
        }

        private void btnInserEmployee_Click(object sender, EventArgs e)
        {
            new InsertEmployee().ShowDialog(this);
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            if (this.productControll1.Visible)
            {
                this.productControll1.Visible = false;
            }
            if (this.manageProduct1.Visible)
            {
                this.manageProduct1.Visible = false;
            }
            if (this.orderDetail1.Visible)
            {
                this.orderDetail1.Visible = false;
            }
            this.listProduct1.Visible = true;
            List<ProductItem> products = ProductItem.getProducts();

            if (products.Count > 0)
            {
                this.listProduct1.tableLayoutProduct.Clear();
                int c = 0, row = 0;
                foreach (ProductItem product in products)
                {
                    Product p = new Product()
                    {
                        ID = product.Id,
                        Picture = product.Photo,
                        PName = product.Name,
                        Price = product.Price,
                    };
                    this.listProduct1.tableLayoutProduct.Add(p, c, row);
                    //Product.Rows.Add(product.Record());
                    c++;
                    if (c > 5)
                    {
                        c = 1;
                        row++;
                    }
                }
            }
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            if (this.listProduct1.Visible)
            {
                this.listProduct1.Visible = false;
            }
            if (this.productControll1.Visible)
            {
                this.productControll1.Visible = false;
            }
            if (this.orderDetail1.Visible)
            {
                this.orderDetail1.Visible = false;
            }
            this.manageProduct1.Visible = true;
            List<ProductItem> products = ProductItem.getProducts();
            if (products.Count > 0)
            {
                this.manageProduct1.Rows.Clear();
                foreach (ProductItem product in products)
                {
                    this.manageProduct1.Rows.Add(product.Record());
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new ProductGridView().ShowDialog(this);
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            if (this.listProduct1.Visible)
            {
                this.listProduct1.Visible = false;
            }
            if (this.productControll1.Visible)
            {
                this.productControll1.Visible = false;
            }
            if (this.manageProduct1.Visible)
            {
                this.manageProduct1.Visible = false;
            }
            this.orderDetail1.Visible = true;
            //DataGridViewRowCollection pro = Product.Rows;
            this.orderDetail1.Rows.Add(1,"Jko", "15","20",$"{15*20}");
            //MessageBox.Show($"Total:{Product.Rows.Count}");
        }
    }
}
