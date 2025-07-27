namespace NotatnikDesktop
{
    partial class StronaStartowa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TytulNotatnika = new Label();
            przyciskRejestracji = new Button();
            przyciskLogowania = new Button();
            SuspendLayout();
            // 
            // TytulNotatnika
            // 
            TytulNotatnika.AutoSize = true;
            TytulNotatnika.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TytulNotatnika.Location = new Point(384, 136);
            TytulNotatnika.Name = "TytulNotatnika";
            TytulNotatnika.Size = new Size(210, 60);
            TytulNotatnika.TabIndex = 0;
            TytulNotatnika.Text = "Notatnik";
            // 
            // przyciskRejestracji
            // 
            przyciskRejestracji.Location = new Point(253, 309);
            przyciskRejestracji.Name = "przyciskRejestracji";
            przyciskRejestracji.Size = new Size(151, 84);
            przyciskRejestracji.TabIndex = 1;
            przyciskRejestracji.Text = "rejestracja";
            przyciskRejestracji.UseVisualStyleBackColor = true;
            przyciskRejestracji.Click += przyciskRejestracji_Click;
            // 
            // przyciskLogowania
            // 
            przyciskLogowania.Location = new Point(581, 309);
            przyciskLogowania.Name = "przyciskLogowania";
            przyciskLogowania.Size = new Size(162, 84);
            przyciskLogowania.TabIndex = 2;
            przyciskLogowania.Text = "logowanie";
            przyciskLogowania.UseVisualStyleBackColor = true;
            przyciskLogowania.Click += przyciskLogowania_Click;
            // 
            // StronaStartowa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 648);
            Controls.Add(przyciskLogowania);
            Controls.Add(przyciskRejestracji);
            Controls.Add(TytulNotatnika);
            Name = "StronaStartowa";
            Text = "Notatnik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TytulNotatnika;
        private Button przyciskRejestracji;
        private Button przyciskLogowania;
    }
}
