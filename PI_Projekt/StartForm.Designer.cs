namespace PI_Projekt
{
    partial class StartForm
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
            label1 = new Label();
            BtnZaposlenik = new Button();
            BtnKupac = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 52);
            label1.Name = "label1";
            label1.Size = new Size(342, 20);
            label1.TabIndex = 0;
            label1.Text = "Želite li korisiti aplikaciju kao zaposlenik ili kupac?";
            label1.Click += label1_Click;
            // 
            // BtnZaposlenik
            // 
            BtnZaposlenik.Location = new Point(66, 95);
            BtnZaposlenik.Name = "BtnZaposlenik";
            BtnZaposlenik.Size = new Size(94, 29);
            BtnZaposlenik.TabIndex = 1;
            BtnZaposlenik.Text = "Zaposlenik";
            BtnZaposlenik.UseVisualStyleBackColor = true;
            BtnZaposlenik.Click += BtnZaposlenik_Click;
            // 
            // BtnKupac
            // 
            BtnKupac.Location = new Point(257, 95);
            BtnKupac.Name = "BtnKupac";
            BtnKupac.Size = new Size(94, 29);
            BtnKupac.TabIndex = 2;
            BtnKupac.Text = "Kupac";
            BtnKupac.UseVisualStyleBackColor = true;
            BtnKupac.Click += BtnKupac_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 164);
            Controls.Add(BtnKupac);
            Controls.Add(BtnZaposlenik);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "Dobrodošli!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnZaposlenik;
        private Button BtnKupac;
    }
}
