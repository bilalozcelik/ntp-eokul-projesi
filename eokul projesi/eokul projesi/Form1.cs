using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace eokul_projesi
{
    public partial class eokulForm : Form
    {
        public eokulForm()
        {
            InitializeComponent();
        }
        sqlbaglantisi bag = new sqlbaglantisi();
        DataTable table = new DataTable();
        MySqlCommand kmt = new MySqlCommand();
        private void eokulForm_Load(object sender, EventArgs e)
        {

        }

        private void tabctrlEokul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlEokul.SelectedIndex == 0)//Ana sayfa
            {
                AnaSayfaYukle();
            }
            else if (tabctrlEokul.SelectedIndex == 1)//Öğrenci işlemleri
            {
                OgrenciYukle();
            }
            else if (tabctrlEokul.SelectedIndex == 2)//Not işlemleri
            {
                NotYukle();
            }
            else //Ders işlemleri
            {
                DersYukle();
            }
        }
        private void DersYukle()
        {
            dataGridViewDers.RowHeadersVisible = false;//Satır başlıkları görünmez yapılır.
            dataGridViewDers.Font = new Font("verdana", 8);// Datagridview için font ayarlaması yapılır.
            table.Columns.Clear();// Tablonun önceki kullanımından kalan sütunlar temizlenir.
            table.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from dersler", bag.baglan());// Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr.Fill(table);//DataAdapter nesnesine yüklenen bilgiler tabloya aktarılır.
            dataGridViewDers.DataSource = table; //Datagridview bileşeni data kaynağı olarak table seçilir.
            dataGridViewDers.Columns["dersKodu"].HeaderText = "Ders Kodu"; //MySQL’den gelen kolon adı Datagridview’de yazılır.
            dataGridViewDers.Columns["dersAdi"].HeaderText = "Ders Adı";
        }
        private void NotYukle()
        {
            dataGridViewNot.RowHeadersVisible = false;//Satır başlıkları görünmez yapılır.
            dataGridViewNot.Font = new Font("verdana", 8);// Datagridview için font ayarlaması yapılır.
            table.Columns.Clear();// Tablonun önceki kullanımından kalan sütunlar temizlenir.
            table.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from ogrencinot", bag.baglan());// Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr.Fill(table);//DataAdapter nesnesine yüklenen bilgiler tabloya aktarılır.
            dataGridViewNot.DataSource = table; //Datagridview bileşeni data kaynağı olarak table seçilir.
            dataGridViewNot.Columns["ogrenciNotId"].HeaderText = "Not ID"; //MySQL’den gelen kolon adı Datagridview’de yazılır.
            dataGridViewNot.Columns["ogrenciNoFK"].HeaderText = "Öğrenci No";
            dataGridViewNot.Columns["dersKoduFK"].HeaderText = "Ders Kodu"; //MySQL’den gelen kolon adı Datagridview’de yazılır.
            dataGridViewNot.Columns["yazili1"].HeaderText = "1. Yazılı";
            dataGridViewNot.Columns["yazili2"].HeaderText = "2. Yazılı";
            dataGridViewNot.Columns["yazili3"].HeaderText = "3. Yazılı";
            dataGridViewNot.Columns["uygulama1"].HeaderText = "1. Uygulama";
            dataGridViewNot.Columns["uygulama2"].HeaderText = "2. Uygulama";
            dataGridViewNot.Columns["sozlu1"].HeaderText = "1. Sözlü";
            dataGridViewNot.Columns["sozlu2"].HeaderText = "2. Sözlü";
            dataGridViewNot.Columns["ortalama"].HeaderText = "Ortalama";
        }
        private void OgrenciYukle()
        {
            dataGridViewOgrenci.RowHeadersVisible = false;//Satır başlıkları görünmez yapılır.
            dataGridViewOgrenci.Font = new Font("verdana", 8);// Datagridview için font ayarlaması yapılır.
            table.Columns.Clear();// Tablonun önceki kullanımından kalan sütunlar temizlenir.
            table.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from ogrencibilgi", bag.baglan());// Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr.Fill(table);//DataAdapter nesnesine yüklenen bilgiler tabloya aktarılır.
            dataGridViewOgrenci.DataSource = table; //Datagridview bileşeni data kaynağı olarak table seçilir.
            dataGridViewOgrenci.Columns["ogrenciNo"].HeaderText = "Numara"; //MySQL’den gelen kolon adı Datagridview’de yazılır.
            dataGridViewOgrenci.Columns["ogrenciAdi"].HeaderText = "Adı";
            dataGridViewOgrenci.Columns["ogrenciSoyadi"].HeaderText = "Soyadı";
            dataGridViewOgrenci.Columns["ogrenciBolumu"].HeaderText = "Bölümü";
            dataGridViewOgrenci.Columns["ogrenciSinifi"].HeaderText = "Sınıfı";
            dataGridViewOgrenci.Columns["ogrenciDogumTarihi"].HeaderText = "D.Tarihi";
        }

        private void AnaSayfaYukle()
        {
            dataGridViewAna.RowHeadersVisible = false;//Satır başlıkları görünmez yapılır.
            dataGridViewAna.Font = new Font("verdana", 8);// Datagridview için font ayarlaması yapılır.
            table.Columns.Clear();// Tablonun önceki kullanımından kalan sütunlar temizlenir.
            table.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr = new MySqlDataAdapter("select ogrencibilgi.ogrenciNo,ogrencibilgi.ogrenciAdi,ogrencibilgi.ogrenciSoyadi,dersler.dersAdi,ogrencinot.yazili1,ogrencinot.yazili2,ogrencinot.yazili3,ogrencinot.uygulama1,ogrencinot.uygulama2,ogrencinot.sozlu1,ogrencinot.sozlu2,ogrencinot.ortalama from ogrencinot inner join ogrencibilgi on ogrencinot.ogrenciNoFK=ogrencibilgi.ogrenciNo inner join dersler on ogrencinot.dersKoduFK=dersler.dersKodu order by ogrencibilgi.ogrenciNo desc;", bag.baglan());// Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr.Fill(table);//DataAdapter nesnesine yüklenen bilgiler tabloya aktarılır.
            dataGridViewAna.DataSource = table; //Datagridview bileşeni data kaynağı olarak table seçilir.
            dataGridViewAna.Columns["ogrenciNo"].HeaderText = "Numara"; //MySQL’den gelen kolon adı Datagridview’de yazılır.
            dataGridViewAna.Columns["ogrenciAdi"].HeaderText = "Adı";
            dataGridViewAna.Columns["ogrenciSoyadi"].HeaderText = "Soyadı"; //MySQL’den gelen kolon adı Datagridview’de yazılır.
            dataGridViewAna.Columns["dersAdi"].HeaderText = "Ders Adı";
            dataGridViewAna.Columns["yazili1"].HeaderText = "1. Yazılı";
            dataGridViewAna.Columns["yazili2"].HeaderText = "2. Yazılı";
            dataGridViewAna.Columns["yazili3"].HeaderText = "3. Yazılı";
            dataGridViewAna.Columns["uygulama1"].HeaderText = "1. Uygulama";
            dataGridViewAna.Columns["uygulama2"].HeaderText = "2. Uygulama";
            dataGridViewAna.Columns["sozlu1"].HeaderText = "1. Sözlü";
            dataGridViewAna.Columns["sozlu2"].HeaderText = "2. Sözlü";
            dataGridViewAna.Columns["ortalama"].HeaderText = "Ortalama";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniKayit kayitForm = new YeniKayit();
            kayitForm.Show();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            DataTable Anatable = new DataTable();
            Anatable = table.Copy();
            DataView dv = Anatable.DefaultView;
            dv.RowFilter = "ogrenciAdi like '%" + txtArama.Text + "%' or ogrenciSoyadi like '%" + txtArama.Text + "%'";
            dataGridViewAna.DataSource = dv;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Silme işlemine devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes)
            {
                try
                {
                    kmt.Connection = bag.baglan();
                    kmt.CommandText = "delete from ogrencibilgi where ogrenciNo='"
                        + dataGridViewOgrenci.CurrentRow.Cells["ogrenciNo"].Value.ToString() + "'";
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi başarılı");
                    OgrenciYukle();
                }
                catch
                {
                    MessageBox.Show("Silme işlemi gerçekleşmedi\nSilinecek öğrencinin diğer alanlarla\nkaydının olmamasına dikkat ediniz");
                }
            }
        }

        private void rbEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEkle.Checked)
            {
                btnEkleGuncelle.Text = "EKLE";
            }
            else
            {
                btnEkleGuncelle.Text = "GÜNCELLE";
            }
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (rbEkle.Checked)
            {
                try
                {
                    kmt.Connection = bag.baglan();
                    kmt.CommandText = "insert into ogrencibilgi (ogrenciNo, ogrenciAdi, ogrenciSoyadi, ogrenciBolumu, ogrenciSinifi, ogrenciDogumTarihi) values ("
                    + txtNumara.Text + ",'" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtBolum.Text + "','" + txtSinif.Text + "','"
                    + dateDogumTarihi.Value.Date.ToString("yyyy-MM-dd") + "')";
                    kmt.ExecuteNonQuery();
                    kmt.Connection.Close();
                    OgrenciYukle();
                    MessageBox.Show("Bilgiler veritabanına başarıyla eklendi");
                }
                catch
                {

                    MessageBox.Show("Ekleme başarısız\nLütfen alanları kontrol ediniz\nAynı numarada iki öğrenci olamaz\nBoş alan olamaz");
                }
            }
            else if (rbGuncelle.Checked)
            {
                try
                {
                    kmt.Connection = bag.baglan();
                    kmt.CommandText = "update ogrencibilgi set ogrenciNo=" + txtNumara.Text + ",ogrenciAdi='"
                        + txtAd.Text + "', ogrenciSoyadi='" + txtSoyad.Text + "', ogrenciBolumu='" + txtBolum.Text
                        + "', ogrenciSinifi='" + txtSinif.Text + "', ogrenciDogumTarihi='" + dateDogumTarihi.Value.Date.ToString("yyyy-MM-dd")
                        + "' where ogrenciNo=' " + dataGridViewOgrenci.CurrentRow.Cells["ogrenciNo"].Value.ToString() + "'";
                    kmt.ExecuteNonQuery();
                    kmt.Connection.Close();
                    OgrenciYukle();
                    MessageBox.Show("Güncelleme işlemi başarılı");
                }
                catch
                {
                    MessageBox.Show("Güncelleme başarısız\nLütfen alanları kontrol ediniz\nAynı numarada iki öğrenci olamaz\nBoş alan olamaz");

                }
            }
        }

        private void dataGridViewOgrenci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumara.Text = dataGridViewOgrenci.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridViewOgrenci.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridViewOgrenci.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBolum.Text = dataGridViewOgrenci.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinif.Text = dataGridViewOgrenci.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateDogumTarihi.Text = dataGridViewOgrenci.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void dataGridViewNot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNotNumara.Text = dataGridViewNot.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNotDersKodu.Text = dataGridViewNot.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNotYazili1.Text = dataGridViewNot.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNotYazili2.Text = dataGridViewNot.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNotYazili3.Text = dataGridViewNot.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNotUygulama1.Text = dataGridViewNot.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNotUygulama2.Text = dataGridViewNot.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtNotSozlu1.Text = dataGridViewNot.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtNotSozlu2.Text = dataGridViewNot.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtNotOrtalama.Text = dataGridViewNot.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int ortalama = 0;
                ortalama = (Convert.ToInt16(txtNotYazili1.Text) + Convert.ToInt16(txtNotYazili2.Text) +
                    Convert.ToInt16(txtNotYazili3.Text) + Convert.ToInt16(txtNotUygulama1.Text) +
                    Convert.ToInt16(txtNotUygulama2.Text) + Convert.ToInt16(txtNotSozlu1.Text) +
                    Convert.ToInt16(txtNotSozlu2.Text)) / 7;
                kmt.Connection = bag.baglan();
                kmt.CommandText = "update ogrencinot set ogrenciNoFK= '" + txtNotNumara.Text
                    + "',dersKoduFK='" + txtNotDersKodu.Text
                    + "',yazili1=" + txtNotYazili1.Text
                    + ",yazili2=" + txtNotYazili2.Text
                    + ",yazili3=" + txtNotYazili3.Text
                    + ",uygulama1=" + txtNotUygulama1.Text
                    + ",uygulama2=" + txtNotUygulama2.Text
                    + ",sozlu1=" + txtNotSozlu1.Text
                    + ",sozlu2=" + txtNotSozlu2.Text
                    + ",ortalama=" + ortalama + " where ogrenciNotId=" + dataGridViewNot.CurrentRow.Cells["ogrenciNotId"].Value.ToString() + "";
                kmt.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı");
                NotYukle();

            }
            catch
            {
                MessageBox.Show("Güncelleme başarısız\nLütfen alanları kontrol ediniz\nAynı numarada iki öğrenci olamaz\nBoş alan olamaz");
            }
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Silme işlemine devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes)
            {
                try
                {
                    kmt.Connection = bag.baglan();
                    kmt.CommandText = "delete from ogrencinot where ogrenciNotId='"
                        + dataGridViewNot.CurrentRow.Cells["ogrenciNotId"].Value.ToString() + "'";
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi başarılı");
                    NotYukle();
                }
                catch
                {
                    MessageBox.Show("Silme işlemi gerçekleşmedi\nSilinecek öğrencinin diğer alanlarla\nkaydının olmamasına dikkat ediniz");
                }
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            kmt.Connection = bag.baglan();
            kmt.CommandText = "insert into dersler (dersKodu, dersAdi) values('"
                + txtDersKodu.Text + "','" + txtDersAdi.Text + "')";
            kmt.ExecuteNonQuery();
            kmt.Connection.Close();
            DersYukle();
            MessageBox.Show("Bilgiler veritabanına başarıyla eklendi");

        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Silme işlemine devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes)
            {
                try
                {
                    kmt.Connection = bag.baglan();
                    kmt.CommandText = "delete from dersler where dersKodu='"
                        + dataGridViewDers.CurrentRow.Cells["dersKodu"].Value.ToString() + "'";
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi başarılı");
                    DersYukle();
                }
                catch
                {
                    MessageBox.Show("Silme işlemi gerçekleşmedi\nSilinecek öğrencinin diğer alanlarla\nkaydının olmamasına dikkat ediniz");
                }
            }
        }
    }
}
