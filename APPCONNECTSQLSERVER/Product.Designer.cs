namespace APPCONNECTSQLSERVER
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrder = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Controls.Add(this.picture);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtPrice);
            this.materialCard1.Controls.Add(this.txtProductName);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(7, 7);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(7);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(7);
            this.materialCard1.Size = new System.Drawing.Size(246, 343);
            this.materialCard1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 36);
            this.panel1.TabIndex = 7;
            // 
            // btnOrder
            // 
            this.btnOrder.AutoSize = false;
            this.btnOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(150)))), ((int)(((byte)(67)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnOrder.Depth = 0;
            this.btnOrder.HighEmphasis = true;
            this.btnOrder.Icon = null;
            this.btnOrder.Location = new System.Drawing.Point(5, 5);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOrder.Size = new System.Drawing.Size(122, 27);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOrder.UseAccentColor = false;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(150)))), ((int)(((byte)(67)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(151, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = true;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture.Image = global::APPCONNECTSQLSERVER.Properties.Resources.incodenitor;
            this.picture.Location = new System.Drawing.Point(7, 7);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(232, 196);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(9, 271);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(103, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Product Price: ";
            // 
            // txtPrice
            // 
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.HideSelection = true;
            this.txtPrice.LeadingIcon = null;
            this.txtPrice.Location = new System.Drawing.Point(124, 254);
            this.txtPrice.MaxLength = 100;
            this.txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PrefixSuffixText = null;
            this.txtPrice.ReadOnly = false;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(115, 36);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "1.5";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.TrailingIcon = null;
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.UseTallSize = false;
            // 
            // txtProductName
            // 
            this.txtProductName.AnimateReadOnly = false;
            this.txtProductName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductName.Depth = 0;
            this.txtProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductName.HideSelection = true;
            this.txtProductName.LeadingIcon = null;
            this.txtProductName.Location = new System.Drawing.Point(124, 212);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PrefixSuffixText = null;
            this.txtProductName.ReadOnly = false;
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(115, 36);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TabStop = false;
            this.txtProductName.Text = "COCA COLA";
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductName.TrailingIcon = null;
            this.txtProductName.UseSystemPasswordChar = false;
            this.txtProductName.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 229);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Product Name: ";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialCard1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(260, 357);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnOrder;
        private System.Windows.Forms.PictureBox picture;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}
