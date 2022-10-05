using ProductManagement.Dbo;
using ProductManagement.Models;

namespace SaleApp.Forms
{
    public partial class AddOrUpdateOrder : Form
    {
        public bool InsertOrUpdate { get; set; }

        public Order OrderInfo { get; set; }

        public OrderDetail OrderDetailInfo { get; set; }

        private readonly OrderRepository _orderRepository = new(Program.ConnectionString);

        private readonly OrderDetailRepository _orderDetailRepository = new(Program.ConnectionString);

        private readonly ProductRepository _productRepository = new(Program.ConnectionString);

        public AddOrUpdateOrder()
        {
            InitializeComponent();
            nudPrice.Controls.RemoveAt(0);
            nudQuantity.Controls.RemoveAt(0);
            LoadProduct();
        }

        private void LoadProduct()
        {
            string cs = Program.ConnectionString;
            var db = new ProductManagementContext(cs);
            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "Id";
            cbProduct.DataSource = db.Products.ToList();
        }

        private void AddOrUpdateOrder_Load(object sender, EventArgs e)
        {
            cbProduct.SelectedIndex = 0;
            lblErrorOrderName.Text = "";
            lblErrorOrderAddress.Text = "";
            lblErrorStatus.Text = "";

            if (InsertOrUpdate == true)
            {
                var product = _productRepository.GetById(int.Parse(OrderDetailInfo.ProductId.ToString()));
                btnAdd.Text = "Update";

                txtName.Text = OrderInfo.CustomerName.ToString();
                txtOrderAddress.Text = OrderInfo.OrderAddress.ToString();
                nudPrice.Value = (int)OrderInfo.Price.Value;
                dtpOrderDate.Value = (DateTime)OrderInfo.OrderDate.Value;
                txtStatus.Text = OrderInfo.Status.ToString();
                cbProduct.Text = product.Name.ToString();
                nudQuantity.Value = (int)OrderDetailInfo.Quantity.Value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtOrderAddress.Text == "" && txtStatus.Text == "")
            {
                lblErrorOrderName.Text = "Please input order name!";
                lblErrorOrderAddress.Text = "Please input order address!";
                lblErrorStatus.Text = "Please input order status!";
            }
            else if (txtName.Text == "")
            {
                lblErrorOrderName.Text = "Please input order name!";
            }
            else if (txtOrderAddress.Text == "")
            {
                lblErrorOrderAddress.Text = "Please input order address!";
            }
            else if (txtStatus.Text == "")
            {
                lblErrorStatus.Text = "Please input order status!";
            }
            else
            {
                var wordAuthorName = txtName.Text.Split();

                foreach (var wordAuthor in wordAuthorName)
                {
                    if (!char.IsUpper(wordAuthor[0]))
                    {
                        lblErrorOrderName.Text = "The name must be capitalized!";
                        return;
                    }
                }

                if (InsertOrUpdate == false)
                {
                    int incrementID = Convert.ToInt32(_orderRepository.Get().Count());

                    var order = new Order()
                    {
                        CustomerName = txtName.Text,
                        OrderAddress = txtOrderAddress.Text,
                        Price = (int)nudPrice.Value,
                        OrderDate = (DateTime)dtpOrderDate.Value,
                        Status = int.Parse(txtStatus.Text),
                    };

                    var orderDetail = new OrderDetail()
                    {
                        ProductId = int.Parse(cbProduct.SelectedValue.ToString()),
                        OrderId = incrementID + 1,
                        Quantity = (int)nudQuantity.Value,
                        Price = (int)nudPrice.Value,
                    };

                    _orderRepository.Create(order);
                    _orderDetailRepository.Create(orderDetail);
                    this.Close();
                }
                else
                {
                    var order = new Order()
                    {
                        Id = OrderInfo.Id,
                        CustomerName = txtName.Text,
                        OrderAddress = txtOrderAddress.Text,
                        Price = (int)nudPrice.Value,
                        OrderDate = (DateTime)dtpOrderDate.Value,
                        Status = int.Parse(txtStatus.Text),
                    };

                    var orderDetail = new OrderDetail()
                    {
                        ProductId = int.Parse(cbProduct.SelectedValue.ToString()),
                        OrderId = OrderInfo.Id,
                        Quantity = (int)nudQuantity.Value,
                        Price = (int)nudPrice.Value,
                    };

                    _orderRepository.Update(order);
                    _orderDetailRepository.Update(orderDetail);
                    this.Close();
                }
            }
        }

        private void CheckValidationName()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorOrderName.Text = "Please enter order name!";
            }
            else
            {
                lblErrorOrderName.Text = "";
            }
        }

        private void CheckValidationAddress()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorOrderAddress.Text = "Please enter order address!";
            }
            else
            {
                lblErrorOrderAddress.Text = "";
            }
        }

        private void CheckValidationStatus()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorStatus.Text = "Please enter order status!";
            }
            else
            {
                lblErrorStatus.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            CheckValidationName();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckValidationName();
        }

        private void txtOrderAddress_Leave(object sender, EventArgs e)
        {
            CheckValidationAddress();
        }

        private void txtOrderAddress_TextChanged(object sender, EventArgs e)
        {
            CheckValidationAddress();
        }

        private void txtStatus_Leave(object sender, EventArgs e)
        {
            CheckValidationStatus();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            CheckValidationStatus();
        }
    }
}
