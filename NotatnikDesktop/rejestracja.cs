using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace NotatnikDesktop
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            hasloPoletekstowe.UseSystemPasswordChar = true;

            
            odslonHaslo.CheckedChanged += checkBoxPokażHaslo_CheckedChanged;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void checkBoxPokażHaslo_CheckedChanged(object sender, EventArgs e)
        {
            hasloPoletekstowe.UseSystemPasswordChar = !odslonHaslo.Checked;
        }


        private void rejestracjaPrzycisk_Click(object sender, EventArgs e)
        {
            string login = loginPoletekstowe.Text;
            string haslo = hasloPoletekstowe.Text;
            if (login == "")
            {
                MessageBox.Show("Nie podano Loginu");
                return;

            }
            if (haslo == "")
            {
                MessageBox.Show("Nie podano hasła");
                return;
            }
            if (Program.LoginHaslo.ContainsKey(login))
            {
                MessageBox.Show("Podany Użytkownik już isnieje");
                return;
            }

            Program.LoginHaslo.Add(login, haslo);
            bazaLogin.Zapislogow();
            MessageBox.Show("Pomyślnie dodano użytkowika");
            StronaStartowa stronaStartowa = new StronaStartowa();
            stronaStartowa.Show();
            this.Close();
        }

        private void menuPowrot_Click(object sender, EventArgs e)
        {
            StronaStartowa stronaStartowa = new StronaStartowa();
            stronaStartowa.Show();
            this.Close();
        }

       
    }
}
