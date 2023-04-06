using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace APPCONNECTSQLSERVER
{
    public partial class ManageProduct : UserControl
    {
        private ProductItem productItem = new ProductItem();
        private ProductForm productForm = new ProductForm();
        public ManageProduct()
        {
            InitializeComponent();
            btnSearch.Enabled = false;
            btnResetSearch.Enabled = false;
        }

        public DataGridViewRowCollection Rows
        {
            get => dataGridViewProduct.Rows;
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productForm.productId = productItem.Id = int.Parse(dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (dataGridViewProduct.Columns[e.ColumnIndex].Name == "delete")
           {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete Yes/No", "Delete", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.Yes)
                {
                    if (ProductItem.delete(productItem.Id))
                    {
                        dataGridViewProduct.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show($"You have been deleted successfuly.");
                    }
                }
           }
            if (dataGridViewProduct.Columns[e.ColumnIndex].Name == "edit")
            {
                double price = 0;
                productItem.Name = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                double.TryParse(dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out price);
                productItem.Price = price;
                productItem.Instock = int.Parse(dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                productItem.Photo = (Image)dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value;

                productForm.btnSave.Text = "Update";
                productForm.txtProductName.Text = productItem.Name;
                productForm.txtProductPrice.Text = $"{productItem.Price}";
                productForm.txtStockIn.Text = $"{productItem.Instock}";
                productForm.picture.Image = productItem.Photo;

                productForm.ShowDialog(this);
                if (productForm.frmEvent.Equals("closingUpdated", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        string[] pstr = productForm.data.Split(',');
                        double pprice = 0;
                        productItem.Name = pstr[0];
                        double.TryParse(pstr[1], NumberStyles.Currency, CultureInfo.CurrentCulture, out pprice);
                        productItem.Price = pprice;
                        productItem.Instock = int.Parse(pstr[2]);
                        productItem.Photo = (Image)(productForm.photo);
                        productForm.clearTextBox();
                        dataGridViewProduct.Rows.Insert(e.RowIndex, productItem.Record());
                        dataGridViewProduct.Rows.RemoveAt(e.RowIndex+1);
                        productItem.update();
                        MessageBox.Show($"You have been updated success.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            productForm.clearTextBox();
            productForm.btnSave.Text = "Save";
            productForm.ShowDialog(this);
            if (productForm.frmEvent.Equals("closingSaved", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string[] pstr = productForm.data.Split(',');
                    double price = 0;
                    productItem.Name = pstr[0];
                    double.TryParse(pstr[1], NumberStyles.Currency, CultureInfo.CurrentCulture, out price);
                    productItem.Price = price;
                    productItem.Instock = int.Parse(pstr[2]);
                    productItem.Photo = (Image)(productForm.photo);
                    productForm.clearTextBox();
                    int lastRowIndex = dataGridViewProduct.Rows.Count - 1;
                    DataGridViewRow lastRow = dataGridViewProduct.Rows[lastRowIndex];
                    productItem.Id = int.Parse(lastRow.Cells[0].Value.ToString()) +1 ;
                    dataGridViewProduct.Rows.Add(productItem.Record());
                    productItem.Save();
                    MessageBox.Show($"You have been created success.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text.Trim().Length >= 1)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string q = txtSearch.Text;
            try
            {
                List<ProductItem> products = ProductItem.getFilterProducts(q);
                if (products.Count() > 0)
                {
                    dataGridViewProduct.Rows.Clear();
                    foreach (ProductItem product in products)
                    {
                        dataGridViewProduct.Rows.Add(product.Record());
                    }
                    btnResetSearch.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No data");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            List<ProductItem> products = ProductItem.getProducts();
            dataGridViewProduct.Rows.Clear();
            foreach (ProductItem product in products)
            {
                dataGridViewProduct.Rows.Add(product.Record());
            }
        }
    }
}
