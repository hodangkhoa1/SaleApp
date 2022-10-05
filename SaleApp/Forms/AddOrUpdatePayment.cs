using ProductManagement.Dbo;
using ProductManagement.Models;

namespace SaleApp.Forms
{
    public partial class AddOrUpdatePayment : Form
    {
        public bool InsertOrUpdate { get; set; }

        public Payment PaymentInfo { get; set; }

        private readonly PaymentRepository _paymentRepository = new(Program.ConnectionString);

        public AddOrUpdatePayment()
        {
            InitializeComponent();
            nudAmount.Controls.RemoveAt(0);
        }

        private void Alert(string message, Notification.enmType type)
        {
            Notification notification = new();
            notification.ShowAlert(message, type);
        }

        private void AddOrUpdatePayment_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                btnAdd.Text = "Update";
                dtpPayTime.Value = (DateTime)PaymentInfo.PayTime;
                nudAmount.Value = (decimal)PaymentInfo.Amount;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (InsertOrUpdate == false)
            {
                var payment = new Payment()
                {
                    PayTime = dtpPayTime.Value,
                    Amount = (double)nudAmount.Value,
                    PayType = txtPayType.Text
                };

                _paymentRepository.Create(payment);
                this.Alert("Add Payment Success", Notification.enmType.Success);
                this.Close();
            }
            else
            {
                var payment = new Payment()
                {
                    Id = PaymentInfo.Id,
                    PayTime = dtpPayTime.Value,
                    Amount = (double)nudAmount.Value,
                    PayType = txtPayType.Text
                };

                _paymentRepository.Update(payment);
                this.Alert("Update Payment Success", Notification.enmType.Success);
                this.Close();
            }
        }
    }
}
