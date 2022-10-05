namespace SaleApp.Forms
{
    partial class AddOrUpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateCategory));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new SaleApp.CustomButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // btnAdd
            // 
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
            this.btnAdd.Location = new System.Drawing.Point(225, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 50);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 58);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter category name";
            this.txtName.Size = new System.Drawing.Size(305, 27);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(225, 145);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderText = "Enter category status";
            this.txtStatus.Size = new System.Drawing.Size(305, 27);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            this.txtStatus.Leave += new System.EventHandler(this.txtStatus_Leave);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(225, 98);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(237, 23);
            this.lblErrorName.TabIndex = 10;
            this.lblErrorName.Text = "Please enter category name!";
            // 
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStatus.Location = new System.Drawing.Point(225, 187);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(240, 23);
            this.lblErrorStatus.TabIndex = 11;
            this.lblErrorStatus.Text = "Please enter category status!";
            // 
            // AddOrUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 323);
            this.Controls.Add(this.lblErrorStatus);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.AddOrUpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private CustomButton btnAdd;
        private TextBox txtName;
        private TextBox txtStatus;
        private Label lblErrorName;
        private Label lblErrorStatus;
    }
}