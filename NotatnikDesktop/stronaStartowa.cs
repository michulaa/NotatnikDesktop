namespace NotatnikDesktop
{
    public partial class StronaStartowa : Form
    {
        public StronaStartowa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void przyciskRejestracji_Click(object sender, EventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.Show();
            this.Hide();
        }

        private void przyciskLogowania_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
            this.Hide();
        }
    }
}
