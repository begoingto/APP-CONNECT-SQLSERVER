namespace APPCONNECTSQLSERVER
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockIn = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProductPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProductName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnClear);
            this.materialCard1.Controls.Add(this.btnSave);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.picture);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.txtStockIn);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txtProductPrice);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtProductName);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 11);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(639, 525);
            this.materialCard1.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(67, 451);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = true;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(390, 451);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSave.Size = new System.Drawing.Size(158, 36);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Photo:";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture.Image = global::APPCONNECTSQLSERVER.Properties.Resources.Avatar_Cat_512;
            this.picture.Location = new System.Drawing.Point(296, 261);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(161, 153);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 36;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nokora", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create Product ";
            // 
            // txtStockIn
            // 
            this.txtStockIn.AnimateReadOnly = false;
            this.txtStockIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtStockIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStockIn.Depth = 0;
            this.txtStockIn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStockIn.HideSelection = true;
            this.txtStockIn.Hint = "Enter stock in";
            this.txtStockIn.LeadingIcon = null;
            this.txtStockIn.Location = new System.Drawing.Point(215, 203);
            this.txtStockIn.MaxLength = 32767;
            this.txtStockIn.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStockIn.Name = "txtStockIn";
            this.txtStockIn.PasswordChar = '\0';
            this.txtStockIn.PrefixSuffixText = null;
            this.txtStockIn.ReadOnly = false;
            this.txtStockIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStockIn.SelectedText = "";
            this.txtStockIn.SelectionLength = 0;
            this.txtStockIn.SelectionStart = 0;
            this.txtStockIn.ShortcutsEnabled = true;
            this.txtStockIn.Size = new System.Drawing.Size(333, 36);
            this.txtStockIn.TabIndex = 14;
            this.txtStockIn.TabStop = false;
            this.txtStockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStockIn.TrailingIcon = null;
            this.txtStockIn.UseSystemPasswordChar = false;
            this.txtStockIn.UseTallSize = false;
            this.txtStockIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockIn_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(61, 220);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(62, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Stock In:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.AnimateReadOnly = false;
            this.txtProductPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductPrice.Depth = 0;
            this.txtProductPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductPrice.HideSelection = true;
            this.txtProductPrice.Hint = "Enter price ";
            this.txtProductPrice.LeadingIcon = null;
            this.txtProductPrice.Location = new System.Drawing.Point(215, 140);
            this.txtProductPrice.MaxLength = 32767;
            this.txtProductPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PrefixSuffixText = null;
            this.txtProductPrice.ReadOnly = false;
            this.txtProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.ShortcutsEnabled = true;
            this.txtProductPrice.Size = new System.Drawing.Size(333, 36);
            this.txtProductPrice.TabIndex = 12;
            this.txtProductPrice.TabStop = false;
            this.txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductPrice.TrailingIcon = null;
            this.txtProductPrice.UseSystemPasswordChar = false;
            this.txtProductPrice.UseTallSize = false;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(61, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Product Price:";
            // 
            // txtProductName
            // 
            this.txtProductName.AnimateReadOnly = false;
            this.txtProductName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductName.Depth = 0;
            this.txtProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductName.HideSelection = true;
            this.txtProductName.Hint = "Enter product name";
            this.txtProductName.LeadingIcon = null;
            this.txtProductName.Location = new System.Drawing.Point(215, 76);
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
            this.txtProductName.Size = new System.Drawing.Size(333, 36);
            this.txtProductName.TabIndex = 10;
            this.txtProductName.TabStop = false;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductName.TrailingIcon = null;
            this.txtProductName.UseSystemPasswordChar = false;
            this.txtProductName.UseTallSize = false;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(61, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Product Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 547);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnClear;
        public MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialTextBox2 txtStockIn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialTextBox2 txtProductPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialTextBox2 txtProductName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}