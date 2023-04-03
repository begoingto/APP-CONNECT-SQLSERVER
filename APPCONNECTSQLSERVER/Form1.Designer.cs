namespace APPCONNECTSQLSERVER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnInserProduct = new System.Windows.Forms.Button();
            this.btnListProduct = new System.Windows.Forms.Button();
            this.btnInserEmployee = new System.Windows.Forms.Button();
            this.btnLottery = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.listProduct1 = new APPCONNECTSQLSERVER.ListProduct();
            this.productControll1 = new APPCONNECTSQLSERVER.ProductControll();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnPayment);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnEditProduct);
            this.groupBox1.Controls.Add(this.btnInserProduct);
            this.groupBox1.Controls.Add(this.btnListProduct);
            this.groupBox1.Controls.Add(this.btnInserEmployee);
            this.groupBox1.Controls.Add(this.btnLottery);
            this.groupBox1.Controls.Add(this.btnEmployee);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 680);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People";
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.Location = new System.Drawing.Point(3, 331);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(248, 39);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Order Detail";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteProduct.Location = new System.Drawing.Point(3, 253);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(248, 39);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditProduct.Location = new System.Drawing.Point(3, 214);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(248, 39);
            this.btnEditProduct.TabIndex = 6;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnInserProduct
            // 
            this.btnInserProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInserProduct.Location = new System.Drawing.Point(3, 175);
            this.btnInserProduct.Name = "btnInserProduct";
            this.btnInserProduct.Size = new System.Drawing.Size(248, 39);
            this.btnInserProduct.TabIndex = 5;
            this.btnInserProduct.Text = "Insert Product";
            this.btnInserProduct.UseVisualStyleBackColor = true;
            this.btnInserProduct.Click += new System.EventHandler(this.btnInserProduct_Click);
            // 
            // btnListProduct
            // 
            this.btnListProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListProduct.Location = new System.Drawing.Point(3, 136);
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Size = new System.Drawing.Size(248, 39);
            this.btnListProduct.TabIndex = 4;
            this.btnListProduct.Text = "List Product";
            this.btnListProduct.UseVisualStyleBackColor = true;
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // btnInserEmployee
            // 
            this.btnInserEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInserEmployee.Location = new System.Drawing.Point(3, 97);
            this.btnInserEmployee.Name = "btnInserEmployee";
            this.btnInserEmployee.Size = new System.Drawing.Size(248, 39);
            this.btnInserEmployee.TabIndex = 3;
            this.btnInserEmployee.Text = "Insert Employee";
            this.btnInserEmployee.UseVisualStyleBackColor = true;
            this.btnInserEmployee.Click += new System.EventHandler(this.btnInserEmployee_Click);
            // 
            // btnLottery
            // 
            this.btnLottery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLottery.Location = new System.Drawing.Point(3, 58);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(248, 39);
            this.btnLottery.TabIndex = 2;
            this.btnLottery.Text = "Lottery Employee";
            this.btnLottery.UseVisualStyleBackColor = true;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.Location = new System.Drawing.Point(3, 19);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(248, 39);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "List Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Nokora", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(6, 628);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(242, 46);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // listProduct1
            // 
            this.listProduct1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listProduct1.AutoSize = true;
            this.listProduct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listProduct1.Location = new System.Drawing.Point(272, 13);
            this.listProduct1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listProduct1.Name = "listProduct1";
            this.listProduct1.Size = new System.Drawing.Size(1124, 823);
            this.listProduct1.TabIndex = 1;
            // 
            // productControll1
            // 
            this.productControll1.Font = new System.Drawing.Font("Nokora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productControll1.Location = new System.Drawing.Point(269, 12);
            this.productControll1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productControll1.Name = "productControll1";
            this.productControll1.Size = new System.Drawing.Size(1060, 628);
            this.productControll1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listProduct1);
            this.Controls.Add(this.productControll1);
            this.Font = new System.Drawing.Font("Nokora", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.Button btnInserEmployee;
        private ListProduct listProduct1;
        private ProductControll productControll1;
        private System.Windows.Forms.Button btnListProduct;
        private System.Windows.Forms.Button btnInserProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPayment;
    }
}

