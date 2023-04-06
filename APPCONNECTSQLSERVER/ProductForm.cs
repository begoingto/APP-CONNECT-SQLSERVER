using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCONNECTSQLSERVER
{
    public partial class ProductForm : Form
    {
        public int productId;
        public string frmEvent="";
        public string data;
        public Image photo;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearTextBox();
        }

        public void clearTextBox()
        {
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtStockIn.Text = string.Empty;
            picture.Image = global::APPCONNECTSQLSERVER.Properties.Resources.Avatar_Cat_512;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProductName.Text.Trim();
                string stPrice = txtProductPrice.Text.Trim();
                string instock = txtStockIn.Text.Trim();
                this.photo = picture.Image;
                bool error = false;

                if (name.Length < 2)
                {
                    error = true;
                    errorProvider.SetError(txtProductName, "Please enter product name is less than two charector");
                    txtProductName.BackColor = Color.Red;
                    txtProductName.ForeColor = Color.White;
                }

                if (stPrice.Length == 0)
                {
                    error = true;
                    errorProvider.SetError(txtProductPrice, "The price field is required.");
                    txtProductPrice.BackColor = Color.Red;
                    txtProductPrice.ForeColor = Color.White;
                }

                if (instock.Length == 0)
                {
                    error = true;
                    errorProvider.SetError(txtStockIn, "The stock in field is required.");
                    txtStockIn.BackColor = Color.Red;
                    txtStockIn.ForeColor = Color.White;
                }
                double price = 0;
                if (!error && productId==0)
                {
                    double.TryParse(stPrice, NumberStyles.Currency, CultureInfo.CurrentCulture, out price);
                    /*ProductItem productItem = new ProductItem(name, price, int.Parse(instock), photo);
                    productItem.Save();*/
                    this.frmEvent = "closingSaved";
                    this.data = $"{name},{price},{int.Parse(instock)}";
                    this.Close();
                }
                else
                {
                    double.TryParse(stPrice, NumberStyles.Currency, CultureInfo.CurrentCulture, out price);
                    this.frmEvent = "closingUpdated";
                    this.data = $"{name},{price},{int.Parse(instock)}";
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    double size = (fileInfo.Length / 1024.0) / 1024.0; // 1024.0 fise byte and 1024.0 kilobyte
                    if (size > 1)
                    {
                        MessageBox.Show("The image file is greater than 1024 byte.", "Error image",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        picture.Image = Image.FromFile(openFileDialog.FileName);
                    }
                }
                catch
                {
                    MessageBox.Show("Please choose currect image format.", "Error image",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                string text = txtProductPrice.Text.Trim();
                if (e.KeyChar == '.')
                {
                    if (text.Length == 0)
                    {
                        txtProductPrice.Text = "0.";
                        txtProductPrice.SelectionStart = 2;
                        e.Handled = true;
                    }
                    else
                    {
                        if (text.Contains('.'))
                        {
                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    if (!char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtStockIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
