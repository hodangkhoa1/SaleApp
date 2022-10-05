namespace SaleApp
{
    partial class FSalesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSalesManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new SaleApp.GradientBackground();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPaymentManagement = new System.Windows.Forms.Button();
            this.btnCategoryManagment = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerRunTitle = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new SaleApp.CustomButton();
            this.btnAdd = new SaleApp.CustomButton();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Angle = 0F;
            this.panelMenu.ColorBottom = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.ColorTop = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnPaymentManagement);
            this.panelMenu.Controls.Add(this.btnCategoryManagment);
            this.panelMenu.Controls.Add(this.btnProductManagement);
            this.panelMenu.Controls.Add(this.btnOrderManagement);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(289, 641);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAbout.Image = global::SaleApp.Properties.Resources.information;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 514);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(289, 90);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About Us";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPaymentManagement
            // 
            this.btnPaymentManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnPaymentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaymentManagement.FlatAppearance.BorderSize = 0;
            this.btnPaymentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPaymentManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPaymentManagement.Image = global::SaleApp.Properties.Resources.debit_card;
            this.btnPaymentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentManagement.Location = new System.Drawing.Point(0, 424);
            this.btnPaymentManagement.Name = "btnPaymentManagement";
            this.btnPaymentManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaymentManagement.Size = new System.Drawing.Size(289, 90);
            this.btnPaymentManagement.TabIndex = 4;
            this.btnPaymentManagement.Text = "Payment Management";
            this.btnPaymentManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentManagement.UseVisualStyleBackColor = false;
            this.btnPaymentManagement.Click += new System.EventHandler(this.btnPaymentManagement_Click);
            // 
            // btnCategoryManagment
            // 
            this.btnCategoryManagment.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoryManagment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoryManagment.FlatAppearance.BorderSize = 0;
            this.btnCategoryManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManagment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategoryManagment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCategoryManagment.Image = global::SaleApp.Properties.Resources.category;
            this.btnCategoryManagment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryManagment.Location = new System.Drawing.Point(0, 334);
            this.btnCategoryManagment.Name = "btnCategoryManagment";
            this.btnCategoryManagment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategoryManagment.Size = new System.Drawing.Size(289, 90);
            this.btnCategoryManagment.TabIndex = 3;
            this.btnCategoryManagment.Text = "Category Managment";
            this.btnCategoryManagment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoryManagment.UseVisualStyleBackColor = false;
            this.btnCategoryManagment.Click += new System.EventHandler(this.btnCategoryManagment_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnProductManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductManagement.FlatAppearance.BorderSize = 0;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProductManagement.Image = global::SaleApp.Properties.Resources.cubes;
            this.btnProductManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductManagement.Location = new System.Drawing.Point(0, 244);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductManagement.Size = new System.Drawing.Size(289, 90);
            this.btnProductManagement.TabIndex = 2;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderManagement.FlatAppearance.BorderSize = 0;
            this.btnOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOrderManagement.Image = global::SaleApp.Properties.Resources.box;
            this.btnOrderManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderManagement.Location = new System.Drawing.Point(0, 154);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrderManagement.Size = new System.Drawing.Size(289, 90);
            this.btnOrderManagement.TabIndex = 1;
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderManagement.UseVisualStyleBackColor = false;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(289, 154);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitle.Controls.Add(this.btnSearch);
            this.panelTitle.Controls.Add(this.txtSearch);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(289, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(965, 154);
            this.panelTitle.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(826, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(476, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.Size = new System.Drawing.Size(344, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(947, 83);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WELCOME TO FSALES MANAGEMENT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.dataGridView1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(289, 154);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(965, 487);
            this.panelDesktop.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 84);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Image = global::SaleApp.Properties.Resources.list;
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.detailToolStripMenuItem.Text = "Order Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::SaleApp.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ProductManagement.Models.Product);
            // 
            // timerRunTitle
            // 
            this.timerRunTitle.Enabled = true;
            this.timerRunTitle.Tick += new System.EventHandler(this.timerRunTitle_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(289, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 119);
            this.panel1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.Orange;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(591, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(292, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FSalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSalesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSales Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FSalesManagement_FormClosed);
            this.Load += new System.EventHandler(this.FSalesManagement_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientBackground panelMenu;
        private Button btnOrderManagement;
        private Panel panelLogo;
        private Button btnPaymentManagement;
        private Button btnCategoryManagment;
        private Button btnProductManagement;
        private Button btnAbout;
        private Panel panelTitle;
        private Label lblTitle;
        private Panel panelDesktop;
        private System.Windows.Forms.Timer timerRunTitle;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem detailToolStripMenuItem;
        private CustomButton btnAdd;
        private CustomButton btnUpdate;
        private TextBox txtSearch;
        private Button btnSearch;
        private BindingSource productBindingSource;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}