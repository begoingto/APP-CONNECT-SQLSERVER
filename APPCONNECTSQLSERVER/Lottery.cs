using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCONNECTSQLSERVER
{
    public partial class Lottery : Form
    {
        List<Employee> employees;
        int index;
        public Lottery()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string text = btn.Text;
            if (text == "start".ToUpper())
            {
                btn.Text = "stop".ToUpper();
                btn.Image = Properties.Resources.power_off;
                timer.Start();
            }
            else
            {
                btn.Text = "start".ToUpper();
                btn.Image = Properties.Resources.start_icon;
                timer.Stop();
                Employee employee = employees[index];
                listBoxEmployee.Items.Add(employee);
                employees.RemoveAt(index);
            }
        }

        private void Lottery_Load(object sender, EventArgs e)
        {
            try
            {
                employees = Employee.GetEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.Abort;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random random= new Random();
            index = random.Next(employees.Count());
            Employee employee= employees[index];
            txtEmail.Text = employee.Email;
            //pictureBox.Image = employee.Photo;
        }

        private void listBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployee.SelectedItems.Count > 0)
            {
                Employee employee = listBoxEmployee.SelectedItem as Employee;
                txtID.Text = employee.Id.ToString("0000");
                txtName.Text = $"{employee.FirstName} {employee.LastName}";
                txtGender.Text = employee.Gender;
                txtDob.Text = employee.DateOfBirth.ToString("D");
                txtMail.Text = employee.Email;
                txtSalary.Text = $"{employee.Salary:c2}";
                txtAddress.Text = employee.Address;
                pictureBox.Image = employee.Photo;
            }
        }
    }
}
