using ProductManagement.Dbo;
using ProductManagement.Models;

namespace SaleApp.Forms
{
    public partial class AddOrUpdateProduct : Form
    {
        public bool InsertOrUpdate { get; set; }

        public Product ProductInfo { get; set; }

        private readonly ProductRepository _productRepository = new(Program.ConnectionString);

        public AddOrUpdateProduct()
        {
            InitializeComponent();
            nudPrice.Controls.RemoveAt(0);
            LoadCategory();
        }

        private void LoadCategory()
        {
            string cs = Program.ConnectionString;
            var db = new ProductManagementContext(cs);
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = db.Categories.ToList();
        }

        private void AddOrUpdateProduct_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
            lblErrorName.Text = "";
            lblErrorStatus.Text = "";

            if (InsertOrUpdate == true)
            {
                string cs = Program.ConnectionString;
                var db = new ProductManagementContext(cs);
                var category = db.Categories.Find(ProductInfo.CategoryId.ToString());
                btnAdd.Text = "Update";

                txtName.Text = ProductInfo.Name.ToString();
                nudPrice.Value = (int)ProductInfo.Price;
                dtpCreatedDate.Value = (DateTime)ProductInfo.CreatedDate;
                txtStatus.Text = ProductInfo.Status.ToString();
                cbCategory.Text = category.Name.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtStatus.Text == "")
            {
                lblErrorName.Text = "Please input product name!";
                lblErrorStatus.Text = "Please input product status!";
            }
            else if (txtName.Text == "")
            {
                lblErrorName.Text = "Please input product name!";
            }
            else if (txtStatus.Text == "")
            {
                lblErrorStatus.Text = "Please input product status!";
            }
            else
            {
                var wordAuthorName = txtName.Text.Split();

                foreach (var wordAuthor in wordAuthorName)
                {
                    if (!char.IsUpper(wordAuthor[0]))
                    {
                        lblErrorName.Text = "The name must be capitalized!";
                        return;
                    }
                }

                if (InsertOrUpdate == false)
                {
                    var product = new Product()
                    {
                        Name = txtName.Text,
                        Price = (int)nudPrice.Value,
                        CreatedDate = dtpCreatedDate.Value,
                        Status = int.Parse(txtStatus.Text),
                        CategoryId = int.Parse(cbCategory.SelectedValue.ToString()),
                    };

                    _productRepository.Create(product);
                    this.Close();
                }
                else
                {
                    var product = new Product()
                    {
                        Id = ProductInfo.Id,
                        Name = txtName.Text,
                        Price = (int)nudPrice.Value,
                        CreatedDate = dtpCreatedDate.Value,
                        Status = int.Parse(txtStatus.Text),
                        CategoryId = int.Parse(cbCategory.SelectedValue.ToString()),
                    };

                    _productRepository.Update(product);
                    this.Close();
                }
            }
        }

        private void CheckValidationName()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorName.Text = "Please enter product name!";
            }
            else
            {
                lblErrorName.Text = "";
            }
        }

        private void CheckValidationStatus()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorStatus.Text = "Please enter product status!";
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
