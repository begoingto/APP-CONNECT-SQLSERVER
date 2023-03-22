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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtIP.Text = "Begoingto";
            comboAuthentication.SelectedIndex= 1;
        }

        private void comboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = txtPassword.Enabled = comboAuthentication.SelectedIndex != 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboAuthentication.SelectedIndex;
                string ip = txtIP.Text.Trim();
                string dbName = "ss20";
                string user = txtUsername.Text;
                string password = txtPassword.Text;

                if (index == 0)
                {
                    DataConnect.ConnectionDB(ip, dbName);
                }
                else
                {
                    DataConnect.ConnectionDB(ip, dbName, user, password);
                }

                DialogResult= DialogResult.OK;

            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error Connection.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
