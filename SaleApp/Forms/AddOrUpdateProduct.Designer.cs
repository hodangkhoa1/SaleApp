namespace SaleApp.Forms
{
    partial class AddOrUpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateProduct));
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new SaleApp.CustomButton();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(297, 232);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderText = "Enter product status";
            this.txtStatus.Size = new System.Drawing.Size(305, 27);
            this.txtStatus.TabIndex = 13;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            this.txtStatus.Leave += new System.EventHandler(this.txtStatus_Leave);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(297, 33);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter product name";
            this.txtName.Size = new System.Drawing.Size(305, 27);
            this.txtName.TabIndex = 12;
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
            this.lblStatus.Location = new System.Drawing.Point(148, 228);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 28);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(148, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(148, 116);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 28);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreatedDate.Location = new System.Drawing.Point(148, 174);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(126, 28);
            this.lblCreatedDate.TabIndex = 15;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // nudPrice
            // 
            this.nudPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrice.Location = new System.Drawing.Point(297, 116);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(305, 27);
            this.nudPrice.TabIndex = 16;
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCreatedDate.Location = new System.Drawing.Point(297, 176);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(305, 27);
            this.dtpCreatedDate.TabIndex = 17;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(148, 304);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 28);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(297, 308);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(305, 28);
            this.cbCategory.TabIndex = 19;
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
            this.btnAdd.Location = new System.Drawing.Point(297, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 50);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(297, 72);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(230, 23);
            this.lblErrorName.TabIndex = 21;
            this.lblErrorName.Text = "Please enter product name!";
            // 
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStatus.Location = new System.Drawing.Point(297, 271);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(233, 23);
            this.lblErrorStatus.TabIndex = 22;
            this.lblErrorStatus.Text = "Please enter product status!";
            // 
            // AddOrUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorStatus);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdateProduct";
            this.Load += new System.EventHandler(this.AddOrUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtStatus;
        private TextBox txtName;
        private Label lblStatus;
        private Label lblName;
        private Label lblPrice;
        private Label lblCreatedDate;
        private NumericUpDown nudPrice;
        private DateTimePicker dtpCreatedDate;
        private Label lblCategory;
        private ComboBox cbCategory;
        private CustomButton btnAdd;
        private Label lblErrorName;
        private Label lblErrorStatus;
    }
}