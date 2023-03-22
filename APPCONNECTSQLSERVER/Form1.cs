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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog(this);
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
    }
}
