namespace NotatnikDesktop
{
    partial class Rejestracja
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
            rejestracjaNapis = new Label();
            loginNapis = new Label();
            hasloNapis = new Label();
            loginPoletekstowe = new TextBox();
            hasloPoletekstowe = new TextBox();
            rejestracjaPrzycisk = new Button();
            menuPowrot = new Button();
            odslonHaslo = new CheckBox();
            SuspendLayout();
            // 
            // rejestracjaNapis
            // 
            rejestracjaNapis.AutoSize = true;
            rejestracjaNapis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rejestracjaNapis.Location = new Point(205, 46);
            rejestracjaNapis.Name = "rejestracjaNapis";
            rejestracjaNapis.Size = new Size(383, 41);
            rejestracjaNapis.TabIndex = 0;
            rejestracjaNapis.Text = "Podaj Dane do Rejestracji:";
            // 
            // loginNapis
            // 
            loginNapis.AutoSize = true;
            loginNapis.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginNapis.Location = new Point(172, 134);
            loginNapis.Name = "loginNapis";
            loginNapis.Size = new Size(76, 31);
            loginNapis.TabIndex = 1;
            loginNapis.Text = "Login:";
            // 
            // hasloNapis
            // 
            hasloNapis.AutoSize = true;
            hasloNapis.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasloNapis.Location = new Point(172, 187);
            hasloNapis.Name = "hasloNapis";
            hasloNapis.Size = new Size(76, 31);
            hasloNapis.TabIndex = 2;
            hasloNapis.Text = "Hasło:";
            // 
            // loginPoletekstowe
            // 
            loginPoletekstowe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPoletekstowe.Location = new Point(306, 134);
            loginPoletekstowe.Name = "loginPoletekstowe";
            loginPoletekstowe.Size = new Size(282, 34);
            loginPoletekstowe.TabIndex = 3;
            // 
            // hasloPoletekstowe
            // 
            hasloPoletekstowe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasloPoletekstowe.Location = new Point(306, 184);
            hasloPoletekstowe.Name = "hasloPoletekstowe";
            hasloPoletekstowe.Size = new Size(282, 34);
            hasloPoletekstowe.TabIndex = 4;
            // 
            // rejestracjaPrzycisk
            // 
            rejestracjaPrzycisk.Location = new Point(258, 272);
            rejestracjaPrzycisk.Name = "rejestracjaPrzycisk";
            rejestracjaPrzycisk.Size = new Size(317, 38);
            rejestracjaPrzycisk.TabIndex = 5;
            rejestracjaPrzycisk.Text = "zarejestruj";
            rejestracjaPrzycisk.UseVisualStyleBackColor = true;
            rejestracjaPrzycisk.Click += rejestracjaPrzycisk_Click;
            // 
            // menuPowrot
            // 
            menuPowrot.Location = new Point(42, 380);
            menuPowrot.Name = "menuPowrot";
            menuPowrot.Size = new Size(129, 33);
            menuPowrot.TabIndex = 6;
            menuPowrot.Text = "wróć";
            menuPowrot.UseVisualStyleBackColor = true;
            menuPowrot.Click += menuPowrot_Click;
            // 
            // odslonHaslo
            // 
            odslonHaslo.AutoSize = true;
            odslonHaslo.Location = new Point(306, 227);
            odslonHaslo.Name = "odslonHaslo";
            odslonHaslo.Size = new Size(110, 24);
            odslonHaslo.TabIndex = 7;
            odslonHaslo.Text = "pokaz haslo";
            odslonHaslo.UseVisualStyleBackColor = true;
            
            // 
            // Rejestracja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(odslonHaslo);
            Controls.Add(menuPowrot);
            Controls.Add(rejestracjaPrzycisk);
            Controls.Add(hasloPoletekstowe);
            Controls.Add(loginPoletekstowe);
            Controls.Add(hasloNapis);
            Controls.Add(loginNapis);
            Controls.Add(rejestracjaNapis);
            Name = "Rejestracja";
            Text = "Notatnik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rejestracjaNapis;
        private Label loginNapis;
        private Label hasloNapis;
        private TextBox loginPoletekstowe;
        private TextBox hasloPoletekstowe;
        private Button rejestracjaPrzycisk;
        private Button menuPowrot;
        private CheckBox odslonHaslo;
    }
}