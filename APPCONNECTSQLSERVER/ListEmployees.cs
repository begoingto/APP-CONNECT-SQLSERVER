using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APPCONNECTSQLSERVER
{
    public partial class ListEmployees : Form
    {
        public ListEmployees()
        {
            InitializeComponent();
        }

        private void ListEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                List<Employee> employees = Employee.GetEmployees();
                foreach (Employee employee in employees)
                {
                    dataGridEmployee.Rows.Add(employee.Record());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult= DialogResult.Cancel;
            }
        }
    }
}
