namespace SaleApp.Forms
{
    partial class AddOrUpdateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateOrder));
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOrderAddress = new System.Windows.Forms.Label();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new SaleApp.CustomButton();
            this.lblErrorOrderName = new System.Windows.Forms.Label();
            this.lblErrorOrderAddress = new System.Windows.Forms.Label();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProduct
            // 
            this.cbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(322, 380);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(305, 28);
            this.cbProduct.TabIndex = 30;
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.Location = new System.Drawing.Point(146, 376);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(81, 28);
            this.lblProduct.TabIndex = 29;
            this.lblProduct.Text = "Product";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOrderDate.Location = new System.Drawing.Point(322, 237);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(305, 27);
            this.dtpOrderDate.TabIndex = 28;
            // 
            // nudPrice
            // 
            this.nudPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrice.Location = new System.Drawing.Point(322, 178);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(305, 27);
            this.nudPrice.TabIndex = 27;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderDate.Location = new System.Drawing.Point(146, 235);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(109, 28);
            this.lblOrderDate.TabIndex = 26;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(146, 173);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 28);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Order Price";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(322, 297);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderText = "Enter Order Status";
            this.txtStatus.Size = new System.Drawing.Size(305, 27);
            this.txtStatus.TabIndex = 24;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            this.txtStatus.Leave += new System.EventHandler(this.txtStatus_Leave);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(322, 23);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter Order Name";
            this.txtName.Size = new System.Drawing.Size(305, 27);
            this.txtName.TabIndex = 23;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(146, 293);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 28);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Order Status";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(146, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 28);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Customer Name";
            // 
            // lblOrderAddress
            // 
            this.lblOrderAddress.AutoSize = true;
            this.lblOrderAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderAddress.Location = new System.Drawing.Point(146, 93);
            this.lblOrderAddress.Name = "lblOrderAddress";
            this.lblOrderAddress.Size = new System.Drawing.Size(138, 28);
            this.lblOrderAddress.TabIndex = 31;
            this.lblOrderAddress.Text = "Order Address";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(322, 97);
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.PlaceholderText = "Enter Order Address";
            this.txtOrderAddress.Size = new System.Drawing.Size(305, 27);
            this.txtOrderAddress.TabIndex = 32;
            this.txtOrderAddress.TextChanged += new System.EventHandler(this.txtOrderAddress_TextChanged);
            this.txtOrderAddress.Leave += new System.EventHandler(this.txtOrderAddress_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(146, 440);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(88, 28);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(322, 445);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(305, 27);
            this.nudQuantity.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(322, 496);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 50);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblErrorOrderName
            // 
            this.lblErrorOrderName.AutoSize = true;
            this.lblErrorOrderName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorOrderName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOrderName.Location = new System.Drawing.Point(323, 60);
            this.lblErrorOrderName.Name = "lblErrorOrderName";
            this.lblErrorOrderName.Size = new System.Drawing.Size(210, 23);
            this.lblErrorOrderName.TabIndex = 36;
            this.lblErrorOrderName.Text = "Please enter order name!";
            // 
            // lblErrorOrderAddress
            // 
            this.lblErrorOrderAddress.AutoSize = true;
            this.lblErrorOrderAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorOrderAddress.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOrderAddress.Location = new System.Drawing.Point(323, 136);
            this.lblErrorOrderAddress.Name = "lblErrorOrderAddress";
            this.lblErrorOrderAddress.Size = new System.Drawing.Size(227, 23);
            this.lblErrorOrderAddress.TabIndex = 37;
            this.lblErrorOrderAddress.Text = "Please enter order address!";
            // 
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStatus.Location = new System.Drawing.Point(323, 337);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(213, 23);
            this.lblErrorStatus.TabIndex = 38;
            this.lblErrorStatus.Text = "Please enter order status!";
            // 
            // AddOrUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.lblErrorStatus);
            this.Controls.Add(this.lblErrorOrderAddress);
            this.Controls.Add(this.lblErrorOrderName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtOrderAddress);
            this.Controls.Add(this.lblOrderAddress);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdateOrder";
            this.Load += new System.EventHandler(this.AddOrUpdateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbProduct;
        private Label lblProduct;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown nudPrice;
        private Label lblOrderDate;
        private Label lblPrice;
        private TextBox txtStatus;
        private TextBox txtName;
        private Label lblStatus;
        private Label lblName;
        private Label lblOrderAddress;
        private TextBox txtOrderAddress;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private CustomButton btnAdd;
        private Label lblErrorOrderName;
        private Label lblErrorOrderAddress;
        private Label lblErrorStatus;
    }
}