using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCONNECTSQLSERVER
{
    public partial class ListProduct : UserControl
    {
        public ListProduct()
        {
            InitializeComponent();

            string[] fileName = Directory.GetFiles("D:\\_semesterII\\C#\\POS_System\\Image");
            int id = 1;
            int c = 0, row = 0;
            Random r = new Random();
            foreach (string f in fileName)
            {
                Image image = Image.FromFile(f);
                string pFleName = Path.GetFileNameWithoutExtension(f);
                double price = r.Next(1, 20);
                Product p = new Product()
                {
                    ID = id++,
                    Picture = image,
                    PName = pFleName,
                    Price = price,
                };
                this.tableLayoutPanel.Controls.Add(p, c, row);
                c++;
                if (c > 5)
                {
                    c = 1;
                    row++;
                }
            }
        }
    }
}
