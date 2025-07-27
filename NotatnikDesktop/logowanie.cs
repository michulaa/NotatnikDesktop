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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();

            this.MaximizeBox = false;       
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            hasloPoletekstowe.UseSystemPasswordChar = true;

            
            odslonHaslo.CheckedChanged += checkBoxPokażHaslo_CheckedChanged;
        }

        private void checkBoxPokażHaslo_CheckedChanged(object sender, EventArgs e)
        {
            hasloPoletekstowe.UseSystemPasswordChar = !odslonHaslo.Checked;
        }

        private void menuPowrot_Click(object sender, EventArgs e)
        {
            StronaStartowa stronaStartowa = new StronaStartowa();
            stronaStartowa.Show();
            this.Close();
        }

        public void LogowaniePrzycisk_Click(object sender, EventArgs e)
        {

            string login = loginPoletekstowe.Text;
            string haslo = hasloPoletekstowe.Text;

            if (Program.LoginHaslo.ContainsKey(login))
            {
                if (haslo == Program.LoginHaslo[login])
                {
                    MessageBox.Show("Zalogowano pomyślnie!");
                    MainProgram notatnik = new MainProgram(login);
                    notatnik.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowe hasło! spróbuj ponownie");
                    return;
                }
            }
            else
            {
                MessageBox.Show("bledny login! sprobuj ponownie");
                return;
            }

        }
    }
}
