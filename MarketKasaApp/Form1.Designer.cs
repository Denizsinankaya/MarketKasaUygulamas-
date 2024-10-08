namespace MarketKasaApp
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnCocaCola = new Button();
            btnFanta = new Button();
            btnDondurma = new Button();
            btnPatlıcan = new Button();
            btnBiber = new Button();
            btnDomates = new Button();
            btnNakit = new Button();
            btnKrediKartı = new Button();
            dG1 = new DataGridView();
            Sil = new DataGridViewButtonColumn();
            lbToplam = new Label();
            gBAdet = new GroupBox();
            btnVazgec = new Button();
            btnKaydet = new Button();
            txtAdet = new TextBox();
            label1 = new Label();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dG1).BeginInit();
            gBAdet.SuspendLayout();
            SuspendLayout();
            // 
            // btnCocaCola
            // 
            btnCocaCola.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnCocaCola.Location = new Point(12, 22);
            btnCocaCola.Name = "btnCocaCola";
            btnCocaCola.Size = new Size(219, 136);
            btnCocaCola.TabIndex = 0;
            btnCocaCola.TabStop = false;
            btnCocaCola.Text = "Coca Cola";
            btnCocaCola.UseVisualStyleBackColor = true;
            btnCocaCola.Click += btnCocaCola_Click;
            // 
            // btnFanta
            // 
            btnFanta.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnFanta.Location = new Point(237, 22);
            btnFanta.Name = "btnFanta";
            btnFanta.Size = new Size(219, 136);
            btnFanta.TabIndex = 1;
            btnFanta.TabStop = false;
            btnFanta.Text = "Fanta";
            btnFanta.UseVisualStyleBackColor = true;
            btnFanta.Click += button2_Click;
            // 
            // btnDondurma
            // 
            btnDondurma.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnDondurma.Location = new Point(462, 22);
            btnDondurma.Name = "btnDondurma";
            btnDondurma.Size = new Size(244, 136);
            btnDondurma.TabIndex = 2;
            btnDondurma.TabStop = false;
            btnDondurma.Text = "Dondurma";
            btnDondurma.UseVisualStyleBackColor = true;
            btnDondurma.Click += button3_Click;
            // 
            // btnPatlıcan
            // 
            btnPatlıcan.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnPatlıcan.Location = new Point(462, 164);
            btnPatlıcan.Name = "btnPatlıcan";
            btnPatlıcan.Size = new Size(244, 136);
            btnPatlıcan.TabIndex = 3;
            btnPatlıcan.TabStop = false;
            btnPatlıcan.Text = "Patlıcan";
            btnPatlıcan.UseVisualStyleBackColor = true;
            btnPatlıcan.Click += btnPatlıcan_Click;
            // 
            // btnBiber
            // 
            btnBiber.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnBiber.Location = new Point(237, 164);
            btnBiber.Name = "btnBiber";
            btnBiber.Size = new Size(219, 136);
            btnBiber.TabIndex = 4;
            btnBiber.TabStop = false;
            btnBiber.Text = "Biber";
            btnBiber.UseVisualStyleBackColor = true;
            btnBiber.Click += btnBiber_Click;
            // 
            // btnDomates
            // 
            btnDomates.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnDomates.Location = new Point(12, 164);
            btnDomates.Name = "btnDomates";
            btnDomates.Size = new Size(219, 136);
            btnDomates.TabIndex = 5;
            btnDomates.TabStop = false;
            btnDomates.Text = "Domates";
            btnDomates.UseVisualStyleBackColor = true;
            btnDomates.Click += button6_Click;
            // 
            // btnNakit
            // 
            btnNakit.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnNakit.Location = new Point(3, 607);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(219, 136);
            btnNakit.TabIndex = 6;
            btnNakit.TabStop = false;
            btnNakit.Text = "Nakit";
            btnNakit.UseVisualStyleBackColor = true;
            btnNakit.Click += btnNakit_Click;
            // 
            // btnKrediKartı
            // 
            btnKrediKartı.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediKartı.Location = new Point(228, 607);
            btnKrediKartı.Name = "btnKrediKartı";
            btnKrediKartı.Size = new Size(228, 136);
            btnKrediKartı.TabIndex = 7;
            btnKrediKartı.TabStop = false;
            btnKrediKartı.Text = "Kredi Kartı";
            btnKrediKartı.UseVisualStyleBackColor = true;
            btnKrediKartı.Click += button8_Click;
            // 
            // dG1
            // 
            dG1.AllowUserToAddRows = false;
            dG1.AllowUserToDeleteRows = false;
            dG1.AllowUserToResizeRows = false;
            dG1.BackgroundColor = SystemColors.Control;
            dG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG1.Columns.AddRange(new DataGridViewColumn[] { Sil });
            dG1.Location = new Point(722, 22);
            dG1.Name = "dG1";
            dG1.RowHeadersVisible = false;
            dG1.RowHeadersWidth = 62;
            dG1.RowTemplate.Height = 33;
            dG1.Size = new Size(571, 569);
            dG1.TabIndex = 8;
            dG1.TabStop = false;
            dG1.CellContentClick += dG1_CellContentClick;
            // 
            // Sil
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Sil";
            Sil.DefaultCellStyle = dataGridViewCellStyle1;
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 6;
            Sil.Name = "Sil";
            Sil.Text = "Sil";
            Sil.Width = 125;
            // 
            // lbToplam
            // 
            lbToplam.BorderStyle = BorderStyle.FixedSingle;
            lbToplam.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbToplam.ForeColor = Color.IndianRed;
            lbToplam.Location = new Point(722, 594);
            lbToplam.Name = "lbToplam";
            lbToplam.Size = new Size(571, 149);
            lbToplam.TabIndex = 9;
            lbToplam.Text = "0,00";
            lbToplam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBAdet
            // 
            gBAdet.Controls.Add(btnVazgec);
            gBAdet.Controls.Add(btnKaydet);
            gBAdet.Controls.Add(txtAdet);
            gBAdet.Controls.Add(label1);
            gBAdet.Location = new Point(237, 306);
            gBAdet.Name = "gBAdet";
            gBAdet.Size = new Size(219, 252);
            gBAdet.TabIndex = 10;
            gBAdet.TabStop = false;
            gBAdet.Visible = false;
            gBAdet.Enter += groupBox1_Enter;
            // 
            // btnVazgec
            // 
            btnVazgec.Location = new Point(36, 187);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(141, 46);
            btnVazgec.TabIndex = 3;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(36, 137);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(141, 44);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(25, 70);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(171, 39);
            txtAdet.TabIndex = 1;
            txtAdet.Text = "1";
            txtAdet.TextAlign = HorizontalAlignment.Center;
            txtAdet.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 32);
            label1.TabIndex = 0;
            label1.Text = "Adet";
            label1.Click += label1_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.RosyBrown;
            btnKapat.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(462, 608);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(244, 135);
            btnKapat.TabIndex = 11;
            btnKapat.TabStop = false;
            btnKapat.Text = "Formu Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 752);
            Controls.Add(btnKapat);
            Controls.Add(gBAdet);
            Controls.Add(lbToplam);
            Controls.Add(dG1);
            Controls.Add(btnKrediKartı);
            Controls.Add(btnNakit);
            Controls.Add(btnDomates);
            Controls.Add(btnBiber);
            Controls.Add(btnPatlıcan);
            Controls.Add(btnDondurma);
            Controls.Add(btnFanta);
            Controls.Add(btnCocaCola);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "MarketKasaUygulaması";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dG1).EndInit();
            gBAdet.ResumeLayout(false);
            gBAdet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCocaCola;
        private Button btnFanta;
        private Button btnDondurma;
        private Button btnPatlıcan;
        private Button btnBiber;
        private Button btnDomates;
        private Button btnNakit;
        private Button btnKrediKartı;
        private DataGridView dG1;
        private Label lbToplam;
        private GroupBox gBAdet;
        private TextBox txtAdet;
        private Label label1;
        private Button btnKaydet;
        private Button btnVazgec;
        private Button btnKapat;
        private DataGridViewButtonColumn Sil;
    }
}