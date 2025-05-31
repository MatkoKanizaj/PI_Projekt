namespace PI_Projekt
{
    partial class LoginForm
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
            BtnPrijava = new Button();
            txtIme = new TextBox();
            txtLozinka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnPrijava
            // 
            BtnPrijava.Location = new Point(153, 178);
            BtnPrijava.Name = "BtnPrijava";
            BtnPrijava.Size = new Size(123, 49);
            BtnPrijava.TabIndex = 0;
            BtnPrijava.Text = "Prijava";
            BtnPrijava.UseVisualStyleBackColor = true;
            BtnPrijava.Click += BtnPrijava_Click;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(192, 34);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(180, 27);
            txtIme.TabIndex = 1;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(192, 96);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(180, 27);
            txtLozinka.TabIndex = 2;
            txtLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 37);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 99);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Lozinka:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 249);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLozinka);
            Controls.Add(txtIme);
            Controls.Add(BtnPrijava);
            Name = "LoginForm";
            Text = "Prijava zaposlenika";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIme;
        private TextBox txtLozinka;
        private Label label1;
        private Label label2;
        private Button BtnPrijava;
    }
}