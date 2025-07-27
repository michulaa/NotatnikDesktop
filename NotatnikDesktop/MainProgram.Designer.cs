namespace NotatnikDesktop
{
    partial class MainProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            przyciskWyjscie = new ToolStripMenuItem();
            przyciskWyloguj = new ToolStripMenuItem();
            zalogowanyNapis = new Label();
            menuBoczne = new Panel();
            label1 = new Label();
            textNotatki = new RichTextBox();
            przyciskDodaj = new Button();
            napisNotatka = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { przyciskWyjscie, przyciskWyloguj });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1655, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // przyciskWyjscie
            // 
            przyciskWyjscie.Name = "przyciskWyjscie";
            przyciskWyjscie.Size = new Size(70, 24);
            przyciskWyjscie.Text = "wyjscie";
            przyciskWyjscie.Click += przyciskWyjscie_Click;
            // 
            // przyciskWyloguj
            // 
            przyciskWyloguj.Name = "przyciskWyloguj";
            przyciskWyloguj.Size = new Size(75, 24);
            przyciskWyloguj.Text = "wyloguj";
            przyciskWyloguj.Click += przyciskWyloguj_Click;
            // 
            // zalogowanyNapis
            // 
            zalogowanyNapis.AutoSize = true;
            zalogowanyNapis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zalogowanyNapis.Location = new Point(1275, 28);
            zalogowanyNapis.Name = "zalogowanyNapis";
            zalogowanyNapis.Size = new Size(0, 28);
            zalogowanyNapis.TabIndex = 1;
            // 
            // menuBoczne
            // 
            menuBoczne.BackColor = SystemColors.ButtonFace;
            menuBoczne.Location = new Point(0, 82);
            menuBoczne.Name = "menuBoczne";
            menuBoczne.Size = new Size(207, 831);
            menuBoczne.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 39);
            label1.Name = "label1";
            label1.Size = new Size(243, 31);
            label1.TabIndex = 0;
            label1.Text = "notatki użytkownika:";
            // 
            // textNotatki
            // 
            textNotatki.Location = new Point(456, 205);
            textNotatki.Name = "textNotatki";
            textNotatki.Size = new Size(963, 599);
            textNotatki.TabIndex = 3;
            textNotatki.Text = "";
            // 
            // przyciskDodaj
            // 
            przyciskDodaj.Location = new Point(1288, 840);
            przyciskDodaj.Name = "przyciskDodaj";
            przyciskDodaj.Size = new Size(131, 39);
            przyciskDodaj.TabIndex = 4;
            przyciskDodaj.Text = "dodaj";
            przyciskDodaj.UseVisualStyleBackColor = true;
            przyciskDodaj.Click += przyciskDodaj_Click;
            // 
            // napisNotatka
            // 
            napisNotatka.AutoSize = true;
            napisNotatka.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            napisNotatka.Location = new Point(797, 149);
            napisNotatka.Name = "napisNotatka";
            napisNotatka.Size = new Size(278, 41);
            napisNotatka.TabIndex = 5;
            napisNotatka.Text = "Podaj Treść Notatki:";
            // 
            // MainProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1655, 913);
            Controls.Add(napisNotatka);
            Controls.Add(przyciskDodaj);
            Controls.Add(textNotatki);
            Controls.Add(label1);
            Controls.Add(menuBoczne);
            Controls.Add(zalogowanyNapis);
            Controls.Add(menuStrip1);
            Name = "MainProgram";
            Text = "Notatnik";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem przyciskWyjscie;
        private ToolStripMenuItem przyciskWyloguj;
        private Label zalogowanyNapis;
        private Panel menuBoczne;
        private Label label1;
        private RichTextBox textNotatki;
        private Button przyciskDodaj;
        private Label napisNotatka;
    }
}