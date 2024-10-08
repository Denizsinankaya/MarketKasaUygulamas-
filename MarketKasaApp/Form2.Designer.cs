namespace MarketKasaApp
{
    partial class Form2
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
            gBAdet = new GroupBox();
            btnVazgec = new Button();
            btnKaydet = new Button();
            txtAdet = new TextBox();
            label1 = new Label();
            gBAdet.SuspendLayout();
            SuspendLayout();
            // 
            // gBAdet
            // 
            gBAdet.Controls.Add(btnVazgec);
            gBAdet.Controls.Add(btnKaydet);
            gBAdet.Controls.Add(txtAdet);
            gBAdet.Controls.Add(label1);
            gBAdet.Location = new Point(154, 39);
            gBAdet.Name = "gBAdet";
            gBAdet.Size = new Size(280, 299);
            gBAdet.TabIndex = 11;
            gBAdet.TabStop = false;
            // 
            // btnVazgec
            // 
            btnVazgec.Location = new Point(25, 212);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(210, 59);
            btnVazgec.TabIndex = 3;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(25, 148);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(210, 58);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(25, 95);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(210, 47);
            txtAdet.TabIndex = 1;
            txtAdet.Text = "1";
            txtAdet.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 43);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Adet";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 408);
            Controls.Add(gBAdet);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Adedi";
            Load += Form2_Load;
            gBAdet.ResumeLayout(false);
            gBAdet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBAdet;
        private Button btnVazgec;
        private Button btnKaydet;
        private TextBox txtAdet;
        private Label label1;
    }
}