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
    public partial class ProductGridView : Form
    {
        public ProductGridView()
        {
            InitializeComponent();
            List<ProductItem> products = new List<ProductItem>();
            products.Add(new ProductItem(1, "Long1"));
            products.Add(new ProductItem(2, "Long2"));
            products.Add(new ProductItem(3, "Long3"));
            products.Add(new ProductItem(4, "Long4"));
            products.Add(new ProductItem(5, "Long5"));
            foreach(ProductItem p in products)
            {
                dataGridView.Rows.Add(p.testRecord());
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete Yes/No", "Delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show($"You have been deleted successfuly.");
                }
            }
        }
    }
}
