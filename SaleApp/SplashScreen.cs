using System.Runtime.InteropServices;

namespace SaleApp
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public SplashScreen()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressBar.Value = 0;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value.ToString() + "%";

            if (progressBar.Value == 100)
            {
                timerProgress.Enabled = false;
                this.Hide();
                this.ShowInTaskbar = false;
                FSalesManagement fSalesManagement = new();
                fSalesManagement.Show();
            }
        }
    }
}
