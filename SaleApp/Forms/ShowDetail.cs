using ProductManagement.Dbo;
using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.Forms
{
    public partial class ShowDetail : Form
    {
        private readonly ProductRepository _productRepository = new(Program.ConnectionString);

        public ShowDetail()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var getProduct = _productRepository.GetById(int.Parse(FSalesManagement.OrderDetailInfo.ProductId.ToString()));

            txtCustomerName.Enabled = false;
            txtOrderAddress.Enabled = false;
            txtPrice.Enabled = false;
            txtOrderDate.Enabled = false;
            txtStatus.Enabled = false;
            txtProduct.Enabled = false;
            txtQuantity.Enabled = false;

            txtCustomerName.Texts = FSalesManagement.OrderInfo.CustomerName;
            txtOrderAddress.Texts = FSalesManagement.OrderInfo.OrderAddress;
            txtPrice.Texts = FSalesManagement.OrderInfo.Price.ToString();
            txtOrderDate.Texts = FSalesManagement.OrderInfo.OrderDate.ToString();
            txtStatus.Texts = FSalesManagement.OrderInfo.Status.ToString();
            txtProduct.Texts = getProduct.Name.ToString();
            txtQuantity.Texts = FSalesManagement.OrderDetailInfo.Quantity.ToString();
        }
    }
}
