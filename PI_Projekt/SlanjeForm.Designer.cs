namespace PI_Projekt
{
    partial class SlanjeForm
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
            comboKonfiguracije = new ComboBox();
            label1 = new Label();
            btnPosalji = new Button();
            txtemail = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            btnNazad = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // comboKonfiguracije
            // 
            comboKonfiguracije.FormattingEnabled = true;
            comboKonfiguracije.Location = new Point(328, 72);
            comboKonfiguracije.Name = "comboKonfiguracije";
            comboKonfiguracije.Size = new Size(226, 28);
            comboKonfiguracije.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 72);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 1;
            label1.Text = "Odabir konfiguracije za slanje";
            label1.Click += label1_Click;
            // 
            // btnPosalji
            // 
            btnPosalji.Location = new Point(309, 293);
            btnPosalji.Name = "btnPosalji";
            btnPosalji.Size = new Size(167, 64);
            btnPosalji.TabIndex = 2;
            btnPosalji.Text = "Pošalji";
            btnPosalji.UseVisualStyleBackColor = true;
            btnPosalji.Click += btnPosalji_click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(328, 145);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(226, 27);
            txtemail.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(127, 224);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(152, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Slanje zaposleniku";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(316, 224);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(160, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dijeljenje na e-mail";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 148);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 6;
            label2.Text = "Unos e-mail adrese za slanje";
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(102, 293);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(167, 64);
            btnNazad.TabIndex = 7;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // SlanjeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 404);
            Controls.Add(btnNazad);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtemail);
            Controls.Add(btnPosalji);
            Controls.Add(label1);
            Controls.Add(comboKonfiguracije);
            Name = "SlanjeForm";
            Text = "SlanjeForm";
            Load += SlanjeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboKonfiguracije;
        private Label label1;
        private Button btnPosalji;
        private TextBox txtemail;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Button btnNazad;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}