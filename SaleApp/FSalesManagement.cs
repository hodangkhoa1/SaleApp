using ProductManagement.Dbo;
using ProductManagement.Models;

namespace SaleApp
{
    public partial class FSalesManagement : Form
    {
        private Button currentButton;
        private string text;
        private int lengthTitle = 0;
        private int indexOption = 0;

        public static Order? OrderInfo;
        public static OrderDetail? OrderDetailInfo;

        private readonly CategoryRepository _categoryRepository = new(Program.ConnectionString);
        private readonly OrderRepository _orderRepository = new(Program.ConnectionString);
        private readonly ProductRepository _productRepository = new(Program.ConnectionString);
        private readonly PaymentRepository _paymentRepository = new(Program.ConnectionString);
        private readonly OrderDetailRepository _orderDetailRepository = new(Program.ConnectionString);

        public FSalesManagement()
        {
            InitializeComponent();
            dataGridView1.ContextMenuStrip.Items[0].Visible = false;
            dataGridView1.ContextMenuStrip.Items[1].Visible = false;
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 192, 0);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = Color.FromArgb(0, 192, 0);
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Alert(string message, Forms.Notification.enmType type)
        {
            Forms.Notification notification = new();
            notification.ShowAlert(message, type);
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Order Management";
            indexOption = 0;
            LoadData();
            ActiveButton(sender);
            EnabledButtonBottom();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Product Management";
            indexOption = 1;
            LoadData();
            ActiveButton(sender);
            EnabledButtonBottom();
        }

        private void btnCategoryManagment_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Category Management";
            indexOption = 2;
            LoadData();
            ActiveButton(sender);
            EnabledButtonBottom();
        }

        private void btnPaymentManagement_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Payment Management";
            indexOption = 3;
            LoadData();
            ActiveButton(sender);
            EnabledButtonBottom();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "About Management";
            ActiveButton(sender);
            DisableButtonBottom();
            dataGridView1.DataSource = null;
        }

        private void timerRunTitle_Tick(object sender, EventArgs e)
        {
            if (lengthTitle < text.Length)
            {
                lblTitle.Text += text.ElementAt(lengthTitle);
                lengthTitle++;
            }
            else
            {
                timerRunTitle.Stop();
            }
        }

        private void FSalesManagement_Load(object sender, EventArgs e)
        {
            text = lblTitle.Text;
            lblTitle.Text = "";
            timerRunTitle.Start();
            DisableButtonBottom();
        }

        private void LoadData()
        {
            string cs = Program.ConnectionString;
            var productManagementContext = new ProductManagementContext(cs);

            switch (indexOption)
            {
                case 0:
                    dataGridView1.DataSource = productManagementContext.Orders.ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = productManagementContext.Products.ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = productManagementContext.Categories.ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = productManagementContext.Payments.ToList();
                    break;
            }

            if (dataGridView1.DataSource == null)
            {
                dataGridView1.ContextMenuStrip.Items[0].Visible = false;
                dataGridView1.ContextMenuStrip.Items[1].Visible = false;
            }
            else
            {
                if (indexOption == 0)
                {
                    dataGridView1.ContextMenuStrip.Items[0].Visible = true;
                }

                dataGridView1.ContextMenuStrip.Items[1].Visible = true;
            }
        }

        private void DeleteData()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    switch (indexOption)
                    {
                        case 0:
                            int orderID = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());

                            var deleteOrder = _orderRepository.GetById(orderID);

                            if (deleteOrder != null)
                            {
                                var deleteOrderDetail = _orderDetailRepository.GetById(orderID);

                                if (deleteOrderDetail != null)
                                {
                                    _orderDetailRepository.Delete(orderID);
                                    _orderRepository.Delete(orderID);
                                }
                                else
                                {
                                    _orderRepository.Delete(orderID);
                                }
                            }
                            this.Alert("Delete Order Success", Forms.Notification.enmType.Success);
                            break;
                        case 1:
                            int productID = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());

                            var deleteProduct = _productRepository.GetById(productID);
                            var checkProduct = _orderDetailRepository.CheckOrderDetail(productID);

                            if (checkProduct.Count == 0)
                            {
                                if (deleteProduct != null)
                                {
                                    _productRepository.Delete(productID);
                                    this.Alert("Delete Product Success", Forms.Notification.enmType.Success);
                                }
                            }
                            else
                            {
                                this.Alert("Cannot Delete Product!", Forms.Notification.enmType.Error);
                            }
                            break;
                        case 2:
                            int categoryID = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());

                            var deleteCategory = _categoryRepository.GetById(categoryID);
                            var checkCategory = _productRepository.CheckProduct(categoryID);

                            if (checkCategory.Count == 0)
                            {
                                if (deleteCategory != null)
                                {
                                    _categoryRepository.Delete(categoryID);
                                    this.Alert("Delete Category Success", Forms.Notification.enmType.Success);
                                }
                            }
                            else
                            {
                                this.Alert("Cannot Delete Category!", Forms.Notification.enmType.Error);
                            }
                            break;
                        case 3:
                            int paymentID = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());

                            var deletePayment = _paymentRepository.GetById(paymentID);

                            if (deletePayment != null)
                            {
                                _paymentRepository.Delete(paymentID);
                                this.Alert("Delete Payment Success", Forms.Notification.enmType.Success);
                            }
                            break;
                    }

                    LoadData();
                }
            }
            else
            {
                this.Alert("Please select item to delete!", Forms.Notification.enmType.Warning);
            }
        }

        private void DisableButtonBottom()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;
        }

        private void EnabledButtonBottom()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (indexOption)
            {
                case 0:
                    Forms.AddOrUpdateOrder addOrder = new()
                    {
                        Text = "Add Order",
                        InsertOrUpdate = false
                    };

                    addOrder.ShowDialog();
                    this.Alert("Add Order Success", Forms.Notification.enmType.Success);
                    break;
                case 1:
                    Forms.AddOrUpdateProduct addProduct = new()
                    {
                        Text = "Add Product",
                        InsertOrUpdate = false
                    };

                    addProduct.ShowDialog();
                    this.Alert("Add Product Success", Forms.Notification.enmType.Success);
                    break;
                case 2:
                    Forms.AddOrUpdateCategory addCategory = new()
                    {
                        Text = "Add Category",
                        InsertOrUpdate = false
                    };

                    addCategory.ShowDialog();
                    this.Alert("Add Category Success", Forms.Notification.enmType.Success);
                    break;
                case 3:
                    Forms.AddOrUpdatePayment addPayment = new()
                    {
                        Text = "Add Payment",
                        InsertOrUpdate = false
                    };

                    addPayment.ShowDialog();
                    this.Alert("Add Payment Success", Forms.Notification.enmType.Success);
                    break;
            }

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                switch (indexOption)
                {
                    case 0:
                        Forms.AddOrUpdateOrder updateOrder = new()
                        {
                            Text = "Update Order",
                            InsertOrUpdate = true,
                            OrderInfo = new Order()
                            {
                                Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value,
                                CustomerName = dataGridView1.SelectedRows[0].Cells["CustomerName"].Value.ToString(),
                                OrderAddress = dataGridView1.SelectedRows[0].Cells["OrderAddress"].Value.ToString(),
                                Price = (double)dataGridView1.SelectedRows[0].Cells["Price"].Value,
                                OrderDate = (DateTime)dataGridView1.SelectedRows[0].Cells["OrderDate"].Value,
                                Status = (int)dataGridView1.SelectedRows[0].Cells["Status"].Value,
                            },
                            OrderDetailInfo = _orderDetailRepository.GetById((int)dataGridView1.SelectedRows[0].Cells["Id"].Value)
                        };

                        updateOrder.ShowDialog();
                        this.Alert("Update Order Success", Forms.Notification.enmType.Success);
                        break;
                    case 1:
                        Forms.AddOrUpdateProduct updateProduct = new()
                        {
                            Text = "Update Product",
                            InsertOrUpdate = true,
                            ProductInfo = new Product()
                            {
                                Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value,
                                Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString(),
                                Price = (double)dataGridView1.SelectedRows[0].Cells["Price"].Value,
                                CreatedDate = (DateTime)dataGridView1.SelectedRows[0].Cells["CreatedDate"].Value,
                                Status = (int)dataGridView1.SelectedRows[0].Cells["Status"].Value,
                                CategoryId = (int)dataGridView1.SelectedRows[0].Cells["CategoryId"].Value,
                            }
                        };

                        updateProduct.ShowDialog();
                        this.Alert("Update Product Success", Forms.Notification.enmType.Success);
                        break;
                    case 2:
                        Forms.AddOrUpdateCategory updateCategory = new()
                        {
                            Text = "Update Category",
                            InsertOrUpdate = true,
                            CategoryInfo = new Category()
                            {
                                Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value,
                                Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString(),
                                Status = (int)dataGridView1.SelectedRows[0].Cells["Status"].Value,
                            }
                        };

                        updateCategory.ShowDialog();
                        this.Alert("Update Category Success", Forms.Notification.enmType.Success);
                        break;
                    case 3:
                        Forms.AddOrUpdatePayment updatePayment = new()
                        {
                            Text = "Update Payment",
                            InsertOrUpdate = true,
                            PaymentInfo = new Payment()
                            {
                                Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value,
                                PayTime = (DateTime)dataGridView1.SelectedRows[0].Cells["PayTime"].Value,
                                Amount = (double)dataGridView1.SelectedRows[0].Cells["Amount"].Value,
                                PayType = dataGridView1.SelectedRows[0].Cells["PayType"].ToString(),
                            }
                        };

                        updatePayment.ShowDialog();
                        this.Alert("Update Payment Success", Forms.Notification.enmType.Success);
                        break;
                }

                LoadData();
            }
            else
            {
                this.Alert("Please select item to update!", Forms.Notification.enmType.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            if (txtSearch.Text == "")
            {
                LoadData();
            }
            else
            {
                switch (indexOption)
                {
                    case 0:
                        dataGridView1.DataSource = _orderRepository.Search(txtSearch.Text);
                        break;
                    case 1:
                        dataGridView1.DataSource = _productRepository.Search(txtSearch.Text);
                        break;
                    case 2:
                        dataGridView1.DataSource = _categoryRepository.Search(txtSearch.Text);
                        break;
                    case 3:

                        break;
                }
            }
        }

        private void FSalesManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderInfo = new()
            {
                Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value,
                CustomerName = dataGridView1.SelectedRows[0].Cells["CustomerName"].Value.ToString(),
                OrderAddress = dataGridView1.SelectedRows[0].Cells["OrderAddress"].Value.ToString(),
                Price = (double)dataGridView1.SelectedRows[0].Cells["Price"].Value,
                OrderDate = (DateTime)dataGridView1.SelectedRows[0].Cells["OrderDate"].Value,
                Status = (int)dataGridView1.SelectedRows[0].Cells["Status"].Value,
            };

            OrderDetailInfo = _orderDetailRepository.GetById((int)dataGridView1.SelectedRows[0].Cells["Id"].Value);

            Forms.ShowDetail showDetail = new();
            showDetail.ShowDialog();
        }
    }
}
