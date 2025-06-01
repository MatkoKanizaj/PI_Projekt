namespace PI_Projekt
{
    partial class ZaposlenikForm
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
            dataGridView1 = new DataGridView();
            txtNaziv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtKolicina = new TextBox();
            label3 = new Label();
            txtCijena = new TextBox();
            label4 = new Label();
            txtproiz = new TextBox();
            label5 = new Label();
            txtTip = new TextBox();
            label6 = new Label();
            txtModel = new TextBox();
            label7 = new Label();
            txtOpis = new TextBox();
            label8 = new Label();
            txtKompatibilnost = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(479, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1068, 559);
            dataGridView1.TabIndex = 0;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(174, 29);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(257, 27);
            txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 216);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Cijena:";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(174, 260);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(257, 27);
            txtKolicina.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 263);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Količina:";
            // 
            // txtCijena
            // 
            txtCijena.Location = new Point(174, 209);
            txtCijena.Name = "txtCijena";
            txtCijena.Size = new Size(257, 27);
            txtCijena.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 123);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "Proizvođač:";
            // 
            // txtproiz
            // 
            txtproiz.Location = new Point(174, 120);
            txtproiz.Name = "txtproiz";
            txtproiz.Size = new Size(257, 27);
            txtproiz.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 77);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 10;
            label5.Text = "Tip:";
            // 
            // txtTip
            // 
            txtTip.Location = new Point(174, 74);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(257, 27);
            txtTip.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 316);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 14;
            label6.Text = "Opis:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(174, 160);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(257, 27);
            txtModel.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 167);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 12;
            label7.Text = "Model:";
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(174, 313);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(257, 27);
            txtOpis.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 369);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 16;
            label8.Text = "Kompatibilnost:";
            // 
            // txtKompatibilnost
            // 
            txtKompatibilnost.Location = new Point(174, 366);
            txtKompatibilnost.Name = "txtKompatibilnost";
            txtKompatibilnost.Size = new Size(257, 27);
            txtKompatibilnost.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(47, 433);
            button1.Name = "button1";
            button1.Size = new Size(125, 50);
            button1.TabIndex = 17;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnDodaj_Click;
            // 
            // button2
            // 
            button2.Location = new Point(271, 528);
            button2.Name = "button2";
            button2.Size = new Size(125, 50);
            button2.TabIndex = 18;
            button2.Text = "Osvježi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(47, 528);
            button3.Name = "button3";
            button3.Size = new Size(125, 50);
            button3.TabIndex = 19;
            button3.Text = "Obriši";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(271, 433);
            button4.Name = "button4";
            button4.Size = new Size(125, 50);
            button4.TabIndex = 20;
            button4.Text = "Uredi";
            button4.UseVisualStyleBackColor = true;
            // 
            // ZaposlenikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 619);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(txtKompatibilnost);
            Controls.Add(label6);
            Controls.Add(txtModel);
            Controls.Add(label7);
            Controls.Add(txtOpis);
            Controls.Add(label5);
            Controls.Add(txtTip);
            Controls.Add(label4);
            Controls.Add(txtproiz);
            Controls.Add(label3);
            Controls.Add(txtCijena);
            Controls.Add(label2);
            Controls.Add(txtKolicina);
            Controls.Add(label1);
            Controls.Add(txtNaziv);
            Controls.Add(dataGridView1);
            Name = "ZaposlenikForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNaziv;
        private Label label1;
        private Label label2;
        private TextBox txtKolicina;
        private Label label3;
        private TextBox txtCijena;
        private Label label4;
        private TextBox txtproiz;
        private Label label5;
        private TextBox txtTip;
        private Label label6;
        private TextBox txtModel;
        private Label label7;
        private TextBox txtOpis;
        private Label label8;
        private TextBox txtKompatibilnost;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}