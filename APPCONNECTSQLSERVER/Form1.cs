using System;
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
            /*Login login = new Login();
            login.ShowDialog(this);*/
            this.productControll1.Visible = false;
            this.listProduct1.Visible = false;
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

        private void productControll1_Load(object sender, EventArgs e)
        {

        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            if (this.productControll1.Visible)
            {
                this.productControll1.Visible = false;
            }
            this.listProduct1.Visible = true;
        }

        private void btnInserProduct_Click(object sender, EventArgs e)
        {
            if (this.listProduct1.Visible)
            {
                this.listProduct1.Visible = false;
            }
            this.productControll1.Visible = true;
        }
    }
}
