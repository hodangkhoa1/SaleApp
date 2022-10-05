using ProductManagement.Dbo;
using ProductManagement.Models;

namespace SaleApp.Forms
{
    public partial class AddOrUpdateCategory : Form
    {
        public bool InsertOrUpdate { get; set; }
        public Category CategoryInfo { get; set; }

        private readonly CategoryRepository _categoryRepository = new(Program.ConnectionString);

        public AddOrUpdateCategory()
        {
            InitializeComponent();
        }

        private void AddOrUpdateCategory_Load(object sender, EventArgs e)
        {
            lblErrorName.Text = "";
            lblErrorStatus.Text = "";

            if (InsertOrUpdate == true)
            {
                btnAdd.Text = "Update";
                txtName.Text = CategoryInfo.Name.ToString();
                txtStatus.Text = CategoryInfo.Status.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtStatus.Text == "")
            {
                lblErrorName.Text = "Please input category name!";
                lblErrorStatus.Text = "Please input category status!";
            }
            else if (txtName.Text == "")
            {
                lblErrorName.Text = "Please input category name!";
            }
            else if (txtStatus.Text == "")
            {
                lblErrorStatus.Text = "Please input category status!";
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
                    var category = new Category()
                    {
                        Name = txtName.Text,
                        Status = int.Parse(txtStatus.Text),
                    };

                    _categoryRepository.Create(category);
                    this.Close();
                }
                else
                {
                    var category = new Category()
                    {
                        Id = CategoryInfo.Id,
                        Name = txtName.Text,
                        Status = int.Parse(txtStatus.Text),
                    };

                    _categoryRepository.Update(category);
                    this.Close();
                }
            }
        }

        private void CheckValidationName()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorName.Text = "Please input category name!";
            }
            else
            {
                lblErrorName.Text = "";
            }
        }

        private void CheckValidationStatus()
        {
            if (string.IsNullOrEmpty(txtStatus.Text))
            {
                lblErrorStatus.Text = "Please input category status!";
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

        private void txtStatus_Leave(object sender, EventArgs e)
        {
            CheckValidationStatus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckValidationName();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            CheckValidationStatus();
        }
    }
}
