using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotatnikDesktop
{
    public partial class MainProgram : Form
    {
        private string _zalogowanyLogin;
        public MainProgram(string login)
        {
            InitializeComponent();
            _zalogowanyLogin = login;
            zalogowanyNapis.Text = $"Zalogowany jako: {_zalogowanyLogin}";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            WyswietlNotatki();

        }


        private void przyciskWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void przyciskWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
        }

        private void WyswietlNotatki()
        {
            menuBoczne.Controls.Clear();

            if (!Program.Notatki.ContainsKey(_zalogowanyLogin) || Program.Notatki[_zalogowanyLogin].Count == 0)
            {
                Label brak = new Label
                {
                    Text = "Brak notatek.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Location = new Point(10, 10)
                };
                menuBoczne.Controls.Add(brak);
                return;
            }

            int y = 10;
            foreach (string tresc in Program.Notatki[_zalogowanyLogin])
            {
                Label notatkaLabel = new Label
                {
                    Text = "- " + tresc,
                    AutoSize = true,
                    MaximumSize = new Size(menuBoczne.Width - 20, 0),
                    Location = new Point(10, y)
                };

                menuBoczne.Controls.Add(notatkaLabel);
                y += notatkaLabel.Height + 10;
            }
        }

        private void przyciskDodaj_Click(object sender, EventArgs e)
        {
            string tresc = textNotatki.Text.Trim();

            if (string.IsNullOrEmpty(tresc) || tresc == "Wpisz treść notatki...")
            {
                MessageBox.Show("Wprowadź treść notatki.");
                return;
            }

            if (!Program.Notatki.ContainsKey(_zalogowanyLogin))
                Program.Notatki[_zalogowanyLogin] = new List<string>();

            Program.Notatki[_zalogowanyLogin].Add(tresc);
            bazaNotatek.ZapiszNotatki();
            textNotatki.Text = "";
            WyswietlNotatki();
        }
        
    }
}
