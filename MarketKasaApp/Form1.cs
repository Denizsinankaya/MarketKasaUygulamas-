namespace MarketKasaApp
{
    public partial class Form1 : Form
    {
        decimal toplam = 0;
        List<Sepet> sepetim = new List<Sepet>();
        Sepet sepet = new Sepet();
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sepet = new Sepet();
            sepet.UrunAdi = "Fanta";
            sepet.Adet = 1;
            sepet.BirimFiyati = 16;
            sepet.Toplam = sepet.Adet * sepet.BirimFiyati;
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Dondurma", 1, 3);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sepet = new Sepet()
            {
                UrunAdi = "Domates",
                Adet = 1,
                BirimFiyati = 5,
                Toplam = 1 * 5
            };
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki ürünler kredi kartý ile ödendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplami();
        }

        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Coca Cola", 1, 17);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        void Form2Cagir(Sepet sepet)
        {
            form2 = new Form2(sepet);
            form2.Show();
            form2._form1 = this;
        }
        void BtnlariKapat()
        {
            bool status = false;
            gBAdet.Visible = true;
            btnCocaCola.Enabled = status;
            btnFanta.Enabled = status;
            btnDondurma.Enabled = status;
            btnDomates.Enabled = status;
            btnBiber.Enabled = status;
            btnPatlýcan.Enabled = status;
            btnNakit.Enabled = status;
            btnKrediKartý.Enabled = status;

        }

        void SepetiGoster()
        {
            dG1.DataSource = "";
            dG1.DataSource = sepetim;
            SepetToplami();
        }
        void SepetToplami()
        {
            toplam = 0;

            foreach (var item in sepetim)
            {
                toplam = item.Toplam + toplam;
            }
            lbToplam.Text = String.Format("{0:C2}", toplam);
        }

        private void btnBiber_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Biber", 1, 6);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnPatlýcan_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Patlýcan", 1, 7);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Vazgeç();
        }

        void Vazgeç()
        {
            txtAdet.Text = "1";
            bool status = true;
            gBAdet.Visible = false;
            btnCocaCola.Enabled = status;
            btnFanta.Enabled = status;
            btnDondurma.Enabled = status;
            btnDomates.Enabled = status;
            btnBiber.Enabled = status;
            btnPatlýcan.Enabled = status;
            btnNakit.Enabled = status;
            btnKrediKartý.Enabled = status;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SepeteUrunEkle();
        }
        public void SepeteUrunEkle(Sepet sepet)
        {
            sepetim.Add(sepet);
            SepetiGoster();

        }

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex >= 0)
            {
                string urunAdi = dG1.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();

                if (MessageBox.Show($"{urunAdi} adli ürünü silmek isitiyor musunuz?",
                    "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sepetim.RemoveAt(e.RowIndex);
                    SepetiGoster();
                }
            }
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki ürünler nakit olarak ödendi");
        }

        void MesajGoster(string message)
        {
            if(sepetim.Count > 0)
            {
                sepetim = new List<Sepet>();
                SepetiGoster();
                MessageBox.Show(message, "Ödeme Yapýldý", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sepetiniz boþ","Hata!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}