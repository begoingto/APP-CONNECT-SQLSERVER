using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace APPCONNECTSQLSERVER
{
    public partial class InsertEmployee : Form
    {
        public InsertEmployee()
        {
            InitializeComponent();
        }

        private void InsertEmployee_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateOfBirth.MaxDate= now.AddYears(-18);
            dateOfBirth.MinDate = now.AddYears(-60);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) 
                && !char.IsWhiteSpace(e.KeyChar)
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                string text = txtSalary.Text.Trim();
                if (e.KeyChar == '.')
                {
                    if (text.Length ==0)
                    {
                        txtSalary.Text = "0.";
                        txtSalary.SelectionStart= 2;
                        e.Handled= true;
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
        
        private void txtSalary_Leave(object sender, EventArgs e)
        {
            string st = txtSalary.Text.Trim();
            if (st.Length != 0 )
            {
                double salary = double.Parse(st);
                txtSalary.Text = salary.ToString("c2");
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            string st = txtSalary.Text.Trim();
            if (st.Length != 0)
            {
                double salary;
                double.TryParse(st, NumberStyles.Currency, CultureInfo.CurrentCulture, out salary);
                txtSalary.Text = salary.ToString("0.00");
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch 
                {
                    MessageBox.Show("Please choose currect image format.", "Error image", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string gender = rMale.Checked ? "M": "F";
                DateTime date = dateOfBirth.Value;
                string stSalary = txtSalary.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtAddress.Text.Trim();
                Image photo = picture.Image;

                bool error = false;

                errorProvider.Clear();
                // Validation First Name
                if (firstName.Length < 2)
                {
                    error = true;
                    errorProvider.SetError(txtFirstName, "Please enter first name is less than two charector");
                    txtFirstName.BackColor= Color.Red;
                    txtFirstName.ForeColor = Color.White;
                }

                if (lastName.Length < 2)
                {
                    error = true;
                    errorProvider.SetError(txtLastName, "Please enter last name is less than two charector");
                    txtLastName.BackColor = Color.Red;
                    txtLastName.ForeColor = Color.White;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.BackColor= Color.White;
            txtFirstName.ForeColor= Color.Black;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.BackColor = Color.White;
            txtLastName.ForeColor = Color.Black;
        }
    }
}
