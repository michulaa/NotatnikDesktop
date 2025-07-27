namespace NotatnikDesktop
{
    partial class Logowanie
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
            logowanieNapis = new Label();
            LogowaniePrzycisk = new Button();
            hasloPoletekstowe = new TextBox();
            loginPoletekstowe = new TextBox();
            hasloNapis = new Label();
            loginNapis = new Label();
            menuPowrot = new Button();
            odslonHaslo = new CheckBox();
            SuspendLayout();
            // 
            // logowanieNapis
            // 
            logowanieNapis.AutoSize = true;
            logowanieNapis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logowanieNapis.Location = new Point(205, 46);
            logowanieNapis.Name = "logowanieNapis";
            logowanieNapis.Size = new Size(391, 41);
            logowanieNapis.TabIndex = 0;
            logowanieNapis.Text = "Podaj Dane do Logowania:";
            // 
            // LogowaniePrzycisk
            // 
            LogowaniePrzycisk.Location = new Point(258, 276);
            LogowaniePrzycisk.Name = "LogowaniePrzycisk";
            LogowaniePrzycisk.Size = new Size(317, 38);
            LogowaniePrzycisk.TabIndex = 10;
            LogowaniePrzycisk.Text = "zaloguj";
            LogowaniePrzycisk.UseVisualStyleBackColor = true;
            LogowaniePrzycisk.Click += LogowaniePrzycisk_Click;
            // 
            // hasloPoletekstowe
            // 
            hasloPoletekstowe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasloPoletekstowe.Location = new Point(306, 184);
            hasloPoletekstowe.Name = "hasloPoletekstowe";
            hasloPoletekstowe.Size = new Size(282, 34);
            hasloPoletekstowe.TabIndex = 9;
            // 
            // loginPoletekstowe
            // 
            loginPoletekstowe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPoletekstowe.Location = new Point(306, 134);
            loginPoletekstowe.Name = "loginPoletekstowe";
            loginPoletekstowe.Size = new Size(282, 34);
            loginPoletekstowe.TabIndex = 8;
            // 
            // hasloNapis
            // 
            hasloNapis.AutoSize = true;
            hasloNapis.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasloNapis.Location = new Point(172, 187);
            hasloNapis.Name = "hasloNapis";
            hasloNapis.Size = new Size(76, 31);
            hasloNapis.TabIndex = 7;
            hasloNapis.Text = "Hasło:";
            // 
            // loginNapis
            // 
            loginNapis.AutoSize = true;
            loginNapis.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginNapis.Location = new Point(172, 134);
            loginNapis.Name = "loginNapis";
            loginNapis.Size = new Size(76, 31);
            loginNapis.TabIndex = 6;
            loginNapis.Text = "Login:";
            // 
            // menuPowrot
            // 
            menuPowrot.Location = new Point(42, 380);
            menuPowrot.Name = "menuPowrot";
            menuPowrot.Size = new Size(129, 33);
            menuPowrot.TabIndex = 11;
            menuPowrot.Text = "wróć";
            menuPowrot.UseVisualStyleBackColor = true;
            menuPowrot.Click += menuPowrot_Click;
            // 
            // odslonHaslo
            // 
            odslonHaslo.AutoSize = true;
            odslonHaslo.Location = new Point(306, 233);
            odslonHaslo.Name = "odslonHaslo";
            odslonHaslo.Size = new Size(110, 24);
            odslonHaslo.TabIndex = 12;
            odslonHaslo.Text = "pokaz haslo";
            odslonHaslo.UseVisualStyleBackColor = true;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(odslonHaslo);
            Controls.Add(menuPowrot);
            Controls.Add(LogowaniePrzycisk);
            Controls.Add(hasloPoletekstowe);
            Controls.Add(loginPoletekstowe);
            Controls.Add(hasloNapis);
            Controls.Add(loginNapis);
            Controls.Add(logowanieNapis);
            Name = "Logowanie";
            Text = "Notatnik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logowanieNapis;
        private Button LogowaniePrzycisk;
        private TextBox hasloPoletekstowe;
        private TextBox loginPoletekstowe;
        private Label hasloNapis;
        private Label loginNapis;
        private Button menuPowrot;
        private CheckBox odslonHaslo;
    }
}