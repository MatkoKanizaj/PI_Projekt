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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 75);
            label1.Name = "label1";
            label1.Size = new Size(494, 28);
            label1.TabIndex = 0;
            label1.Text = "Želite li korisiti aplikaciju kao zaposlenik ili kupac?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // BtnZaposlenik
            // 
            BtnZaposlenik.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnZaposlenik.FlatStyle = FlatStyle.System;
            BtnZaposlenik.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            BtnZaposlenik.Location = new Point(358, 177);
            BtnZaposlenik.Name = "BtnZaposlenik";
            BtnZaposlenik.Size = new Size(142, 60);
            BtnZaposlenik.TabIndex = 1;
            BtnZaposlenik.Text = "Zaposlenik";
            BtnZaposlenik.UseVisualStyleBackColor = true;
            BtnZaposlenik.Click += BtnZaposlenik_Click;
            // 
            // BtnKupac
            // 
            BtnKupac.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnKupac.BackColor = Color.LightSteelBlue;
            BtnKupac.FlatStyle = FlatStyle.System;
            BtnKupac.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            BtnKupac.Location = new Point(97, 177);
            BtnKupac.Name = "BtnKupac";
            BtnKupac.Size = new Size(142, 60);
            BtnKupac.TabIndex = 2;
            BtnKupac.Text = "Kupac";
            BtnKupac.UseVisualStyleBackColor = false;
            BtnKupac.Click += BtnKupac_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(601, 315);
            Controls.Add(BtnKupac);
            Controls.Add(BtnZaposlenik);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "StartForm";
            Text = "EasyParts - Odaberite ulogu";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnZaposlenik;
        private Button BtnKupac;
    }
}
