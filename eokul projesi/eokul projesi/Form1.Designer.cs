
namespace eokul_projesi
{
    partial class eokulForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eokulForm));
            this.tabctrlEokul = new System.Windows.Forms.TabControl();
            this.tabPageAna = new System.Windows.Forms.TabPage();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAna = new System.Windows.Forms.DataGridView();
            this.tabPageOgrenci = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbGuncelle = new System.Windows.Forms.RadioButton();
            this.rbEkle = new System.Windows.Forms.RadioButton();
            this.dataGridViewOgrenci = new System.Windows.Forms.DataGridView();
            this.tabPageNot = new System.Windows.Forms.TabPage();
            this.dataGridViewNot = new System.Windows.Forms.DataGridView();
            this.tabPageDers = new System.Windows.Forms.TabPage();
            this.dataGridViewDers = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNotYazili3 = new System.Windows.Forms.TextBox();
            this.txtNotYazili2 = new System.Windows.Forms.TextBox();
            this.txtNotYazili1 = new System.Windows.Forms.TextBox();
            this.txtNotDersKodu = new System.Windows.Forms.TextBox();
            this.txtNotNumara = new System.Windows.Forms.TextBox();
            this.btnNotSil = new System.Windows.Forms.Button();
            this.btnNotGuncelle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNotOrtalama = new System.Windows.Forms.TextBox();
            this.txtNotSozlu2 = new System.Windows.Forms.TextBox();
            this.txtNotSozlu1 = new System.Windows.Forms.TextBox();
            this.txtNotUygulama2 = new System.Windows.Forms.TextBox();
            this.txtNotUygulama1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabctrlEokul.SuspendLayout();
            this.tabPageAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAna)).BeginInit();
            this.tabPageOgrenci.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).BeginInit();
            this.tabPageNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNot)).BeginInit();
            this.tabPageDers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDers)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlEokul
            // 
            this.tabctrlEokul.Controls.Add(this.tabPageAna);
            this.tabctrlEokul.Controls.Add(this.tabPageOgrenci);
            this.tabctrlEokul.Controls.Add(this.tabPageNot);
            this.tabctrlEokul.Controls.Add(this.tabPageDers);
            this.tabctrlEokul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlEokul.ImageList = this.ımageList1;
            this.tabctrlEokul.Location = new System.Drawing.Point(0, 0);
            this.tabctrlEokul.Margin = new System.Windows.Forms.Padding(7);
            this.tabctrlEokul.Name = "tabctrlEokul";
            this.tabctrlEokul.SelectedIndex = 0;
            this.tabctrlEokul.Size = new System.Drawing.Size(1080, 619);
            this.tabctrlEokul.TabIndex = 0;
            this.tabctrlEokul.SelectedIndexChanged += new System.EventHandler(this.tabctrlEokul_SelectedIndexChanged);
            // 
            // tabPageAna
            // 
            this.tabPageAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPageAna.Controls.Add(this.txtArama);
            this.tabPageAna.Controls.Add(this.label1);
            this.tabPageAna.Controls.Add(this.button1);
            this.tabPageAna.Controls.Add(this.dataGridViewAna);
            this.tabPageAna.ImageKey = "image1.jpg";
            this.tabPageAna.Location = new System.Drawing.Point(4, 47);
            this.tabPageAna.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageAna.Name = "tabPageAna";
            this.tabPageAna.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageAna.Size = new System.Drawing.Size(1072, 568);
            this.tabPageAna.TabIndex = 0;
            this.tabPageAna.Text = "Ana Sayfa";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(370, 499);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(230, 41);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(241, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(10, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "KAYIT EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAna
            // 
            this.dataGridViewAna.AllowUserToAddRows = false;
            this.dataGridViewAna.AllowUserToDeleteRows = false;
            this.dataGridViewAna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAna.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAna.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewAna.MultiSelect = false;
            this.dataGridViewAna.Name = "dataGridViewAna";
            this.dataGridViewAna.ReadOnly = true;
            this.dataGridViewAna.RowHeadersWidth = 51;
            this.dataGridViewAna.RowTemplate.Height = 24;
            this.dataGridViewAna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAna.Size = new System.Drawing.Size(1028, 472);
            this.dataGridViewAna.TabIndex = 0;
            // 
            // tabPageOgrenci
            // 
            this.tabPageOgrenci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageOgrenci.Controls.Add(this.panel1);
            this.tabPageOgrenci.Controls.Add(this.dataGridViewOgrenci);
            this.tabPageOgrenci.ImageKey = "image2.png";
            this.tabPageOgrenci.Location = new System.Drawing.Point(4, 47);
            this.tabPageOgrenci.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageOgrenci.Name = "tabPageOgrenci";
            this.tabPageOgrenci.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageOgrenci.Size = new System.Drawing.Size(1072, 568);
            this.tabPageOgrenci.TabIndex = 1;
            this.tabPageOgrenci.Text = "Öğrenci İşleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dateDogumTarihi);
            this.panel1.Controls.Add(this.txtSinif);
            this.panel1.Controls.Add(this.txtBolum);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtNumara);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnEkleGuncelle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbGuncelle);
            this.panel1.Controls.Add(this.rbEkle);
            this.panel1.Location = new System.Drawing.Point(694, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 548);
            this.panel1.TabIndex = 2;
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDogumTarihi.Location = new System.Drawing.Point(161, 338);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(179, 30);
            this.dateDogumTarihi.TabIndex = 6;
            // 
            // txtSinif
            // 
            this.txtSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinif.Location = new System.Drawing.Point(163, 295);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(140, 34);
            this.txtSinif.TabIndex = 5;
            // 
            // txtBolum
            // 
            this.txtBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolum.Location = new System.Drawing.Point(163, 253);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(140, 34);
            this.txtBolum.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(163, 206);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(140, 34);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(163, 159);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(140, 34);
            this.txtAd.TabIndex = 5;
            // 
            // txtNumara
            // 
            this.txtNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumara.Location = new System.Drawing.Point(163, 117);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(140, 34);
            this.txtNumara.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(188, 393);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 42);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleGuncelle.Location = new System.Drawing.Point(33, 393);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(126, 42);
            this.btnEkleGuncelle.TabIndex = 3;
            this.btnEkleGuncelle.Text = "EKLE";
            this.btnEkleGuncelle.UseVisualStyleBackColor = true;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "D.Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sınıf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bölüm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numara";
            // 
            // rbGuncelle
            // 
            this.rbGuncelle.AutoSize = true;
            this.rbGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGuncelle.Location = new System.Drawing.Point(165, 38);
            this.rbGuncelle.Name = "rbGuncelle";
            this.rbGuncelle.Size = new System.Drawing.Size(159, 29);
            this.rbGuncelle.TabIndex = 1;
            this.rbGuncelle.Text = "Kayıt Güncelle";
            this.rbGuncelle.UseVisualStyleBackColor = true;
            // 
            // rbEkle
            // 
            this.rbEkle.AutoSize = true;
            this.rbEkle.Checked = true;
            this.rbEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEkle.Location = new System.Drawing.Point(26, 38);
            this.rbEkle.Name = "rbEkle";
            this.rbEkle.Size = new System.Drawing.Size(120, 29);
            this.rbEkle.TabIndex = 0;
            this.rbEkle.TabStop = true;
            this.rbEkle.Text = "Kayıt Ekle";
            this.rbEkle.UseVisualStyleBackColor = true;
            this.rbEkle.CheckedChanged += new System.EventHandler(this.rbEkle_CheckedChanged);
            // 
            // dataGridViewOgrenci
            // 
            this.dataGridViewOgrenci.AllowUserToAddRows = false;
            this.dataGridViewOgrenci.AllowUserToDeleteRows = false;
            this.dataGridViewOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenci.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOgrenci.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewOgrenci.MultiSelect = false;
            this.dataGridViewOgrenci.Name = "dataGridViewOgrenci";
            this.dataGridViewOgrenci.ReadOnly = true;
            this.dataGridViewOgrenci.RowHeadersWidth = 51;
            this.dataGridViewOgrenci.RowTemplate.Height = 24;
            this.dataGridViewOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgrenci.Size = new System.Drawing.Size(678, 548);
            this.dataGridViewOgrenci.TabIndex = 1;
            this.dataGridViewOgrenci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgrenci_CellDoubleClick);
            // 
            // tabPageNot
            // 
            this.tabPageNot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageNot.Controls.Add(this.panel2);
            this.tabPageNot.Controls.Add(this.dataGridViewNot);
            this.tabPageNot.ImageKey = "image3.png";
            this.tabPageNot.Location = new System.Drawing.Point(4, 47);
            this.tabPageNot.Name = "tabPageNot";
            this.tabPageNot.Size = new System.Drawing.Size(1072, 568);
            this.tabPageNot.TabIndex = 2;
            this.tabPageNot.Text = "Not İşlemleri";
            // 
            // dataGridViewNot
            // 
            this.dataGridViewNot.AllowUserToAddRows = false;
            this.dataGridViewNot.AllowUserToDeleteRows = false;
            this.dataGridViewNot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNot.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewNot.MultiSelect = false;
            this.dataGridViewNot.Name = "dataGridViewNot";
            this.dataGridViewNot.ReadOnly = true;
            this.dataGridViewNot.RowHeadersWidth = 51;
            this.dataGridViewNot.RowTemplate.Height = 24;
            this.dataGridViewNot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNot.Size = new System.Drawing.Size(682, 552);
            this.dataGridViewNot.TabIndex = 1;
            this.dataGridViewNot.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNot_CellDoubleClick);
            // 
            // tabPageDers
            // 
            this.tabPageDers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPageDers.Controls.Add(this.panel3);
            this.tabPageDers.Controls.Add(this.dataGridViewDers);
            this.tabPageDers.ImageKey = "image4.png";
            this.tabPageDers.Location = new System.Drawing.Point(4, 47);
            this.tabPageDers.Name = "tabPageDers";
            this.tabPageDers.Size = new System.Drawing.Size(1072, 568);
            this.tabPageDers.TabIndex = 3;
            this.tabPageDers.Text = "Ders İşlemleri";
            // 
            // dataGridViewDers
            // 
            this.dataGridViewDers.AllowUserToAddRows = false;
            this.dataGridViewDers.AllowUserToDeleteRows = false;
            this.dataGridViewDers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDers.Location = new System.Drawing.Point(8, 7);
            this.dataGridViewDers.MultiSelect = false;
            this.dataGridViewDers.Name = "dataGridViewDers";
            this.dataGridViewDers.ReadOnly = true;
            this.dataGridViewDers.RowHeadersWidth = 51;
            this.dataGridViewDers.RowTemplate.Height = 24;
            this.dataGridViewDers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDers.Size = new System.Drawing.Size(628, 553);
            this.dataGridViewDers.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "image1.jpg");
            this.ımageList1.Images.SetKeyName(1, "image2.png");
            this.ımageList1.Images.SetKeyName(2, "image3.png");
            this.ımageList1.Images.SetKeyName(3, "image4.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtNotOrtalama);
            this.panel2.Controls.Add(this.txtNotSozlu2);
            this.panel2.Controls.Add(this.txtNotSozlu1);
            this.panel2.Controls.Add(this.txtNotUygulama2);
            this.panel2.Controls.Add(this.txtNotUygulama1);
            this.panel2.Controls.Add(this.txtNotYazili3);
            this.panel2.Controls.Add(this.txtNotYazili2);
            this.panel2.Controls.Add(this.txtNotYazili1);
            this.panel2.Controls.Add(this.txtNotDersKodu);
            this.panel2.Controls.Add(this.txtNotNumara);
            this.panel2.Controls.Add(this.btnNotSil);
            this.panel2.Controls.Add(this.btnNotGuncelle);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(696, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 551);
            this.panel2.TabIndex = 3;
            // 
            // txtNotYazili3
            // 
            this.txtNotYazili3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotYazili3.Location = new System.Drawing.Point(186, 190);
            this.txtNotYazili3.Name = "txtNotYazili3";
            this.txtNotYazili3.Size = new System.Drawing.Size(140, 34);
            this.txtNotYazili3.TabIndex = 5;
            // 
            // txtNotYazili2
            // 
            this.txtNotYazili2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotYazili2.Location = new System.Drawing.Point(186, 146);
            this.txtNotYazili2.Name = "txtNotYazili2";
            this.txtNotYazili2.Size = new System.Drawing.Size(140, 34);
            this.txtNotYazili2.TabIndex = 5;
            // 
            // txtNotYazili1
            // 
            this.txtNotYazili1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotYazili1.Location = new System.Drawing.Point(186, 102);
            this.txtNotYazili1.Name = "txtNotYazili1";
            this.txtNotYazili1.Size = new System.Drawing.Size(140, 34);
            this.txtNotYazili1.TabIndex = 5;
            // 
            // txtNotDersKodu
            // 
            this.txtNotDersKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotDersKodu.Location = new System.Drawing.Point(186, 58);
            this.txtNotDersKodu.Name = "txtNotDersKodu";
            this.txtNotDersKodu.Size = new System.Drawing.Size(140, 34);
            this.txtNotDersKodu.TabIndex = 5;
            // 
            // txtNotNumara
            // 
            this.txtNotNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotNumara.Location = new System.Drawing.Point(186, 14);
            this.txtNotNumara.Name = "txtNotNumara";
            this.txtNotNumara.Size = new System.Drawing.Size(140, 34);
            this.txtNotNumara.TabIndex = 5;
            // 
            // btnNotSil
            // 
            this.btnNotSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotSil.Location = new System.Drawing.Point(186, 463);
            this.btnNotSil.Name = "btnNotSil";
            this.btnNotSil.Size = new System.Drawing.Size(127, 42);
            this.btnNotSil.TabIndex = 4;
            this.btnNotSil.Text = "SİL";
            this.btnNotSil.UseVisualStyleBackColor = true;
            this.btnNotSil.Click += new System.EventHandler(this.btnNotSil_Click);
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGuncelle.Location = new System.Drawing.Point(31, 463);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(126, 42);
            this.btnNotGuncelle.TabIndex = 3;
            this.btnNotGuncelle.Text = "GÜNCELLE";
            this.btnNotGuncelle.UseVisualStyleBackColor = true;
            this.btnNotGuncelle.Click += new System.EventHandler(this.btnNotGuncelle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(26, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "Numara";
            // 
            // txtNotOrtalama
            // 
            this.txtNotOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotOrtalama.Location = new System.Drawing.Point(186, 410);
            this.txtNotOrtalama.Name = "txtNotOrtalama";
            this.txtNotOrtalama.Size = new System.Drawing.Size(140, 34);
            this.txtNotOrtalama.TabIndex = 6;
            // 
            // txtNotSozlu2
            // 
            this.txtNotSozlu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotSozlu2.Location = new System.Drawing.Point(186, 366);
            this.txtNotSozlu2.Name = "txtNotSozlu2";
            this.txtNotSozlu2.Size = new System.Drawing.Size(140, 34);
            this.txtNotSozlu2.TabIndex = 7;
            // 
            // txtNotSozlu1
            // 
            this.txtNotSozlu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotSozlu1.Location = new System.Drawing.Point(186, 322);
            this.txtNotSozlu1.Name = "txtNotSozlu1";
            this.txtNotSozlu1.Size = new System.Drawing.Size(140, 34);
            this.txtNotSozlu1.TabIndex = 8;
            // 
            // txtNotUygulama2
            // 
            this.txtNotUygulama2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotUygulama2.Location = new System.Drawing.Point(186, 278);
            this.txtNotUygulama2.Name = "txtNotUygulama2";
            this.txtNotUygulama2.Size = new System.Drawing.Size(140, 34);
            this.txtNotUygulama2.TabIndex = 9;
            // 
            // txtNotUygulama1
            // 
            this.txtNotUygulama1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotUygulama1.Location = new System.Drawing.Point(186, 234);
            this.txtNotUygulama1.Name = "txtNotUygulama1";
            this.txtNotUygulama1.Size = new System.Drawing.Size(140, 34);
            this.txtNotUygulama1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ders Kodu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(26, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "1. Yazılı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(26, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "2. Yazılı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(26, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "3. Yazılı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(25, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 29);
            this.label12.TabIndex = 11;
            this.label12.Text = "1. Uygulama";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(26, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 29);
            this.label14.TabIndex = 11;
            this.label14.Text = "2. Uygulama";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(26, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 29);
            this.label15.TabIndex = 11;
            this.label15.Text = "1. Sözlü";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(26, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 29);
            this.label16.TabIndex = 11;
            this.label16.Text = "2. Sözlü";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(26, 410);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 29);
            this.label17.TabIndex = 11;
            this.label17.Text = "Ortalama";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.txtDersAdi);
            this.panel3.Controls.Add(this.txtDersKodu);
            this.panel3.Controls.Add(this.btnDersSil);
            this.panel3.Controls.Add(this.btnDersEkle);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Location = new System.Drawing.Point(670, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 276);
            this.panel3.TabIndex = 3;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersAdi.Location = new System.Drawing.Point(170, 103);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(173, 34);
            this.txtDersAdi.TabIndex = 5;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersKodu.Location = new System.Drawing.Point(170, 61);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(173, 34);
            this.txtDersKodu.TabIndex = 5;
            // 
            // btnDersSil
            // 
            this.btnDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersSil.Location = new System.Drawing.Point(190, 158);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(127, 42);
            this.btnDersSil.TabIndex = 4;
            this.btnDersSil.Text = "SİL";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(35, 158);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(126, 42);
            this.btnDersEkle.TabIndex = 3;
            this.btnDersEkle.Text = "EKLE";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(20, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 29);
            this.label22.TabIndex = 2;
            this.label22.Text = "Ders Adı";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(17, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(127, 29);
            this.label23.TabIndex = 2;
            this.label23.Text = "Ders Kodu";
            // 
            // eokulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1080, 619);
            this.Controls.Add(this.tabctrlEokul);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "eokulForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Okul Programı";
            this.Load += new System.EventHandler(this.eokulForm_Load);
            this.tabctrlEokul.ResumeLayout(false);
            this.tabPageAna.ResumeLayout(false);
            this.tabPageAna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAna)).EndInit();
            this.tabPageOgrenci.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).EndInit();
            this.tabPageNot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNot)).EndInit();
            this.tabPageDers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlEokul;
        private System.Windows.Forms.TabPage tabPageAna;
        private System.Windows.Forms.TabPage tabPageOgrenci;
        private System.Windows.Forms.TabPage tabPageNot;
        private System.Windows.Forms.TabPage tabPageDers;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridViewAna;
        private System.Windows.Forms.DataGridView dataGridViewOgrenci;
        private System.Windows.Forms.DataGridView dataGridViewNot;
        private System.Windows.Forms.DataGridView dataGridViewDers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEkle;
        private System.Windows.Forms.RadioButton rbGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNotOrtalama;
        private System.Windows.Forms.TextBox txtNotSozlu2;
        private System.Windows.Forms.TextBox txtNotSozlu1;
        private System.Windows.Forms.TextBox txtNotUygulama2;
        private System.Windows.Forms.TextBox txtNotUygulama1;
        private System.Windows.Forms.TextBox txtNotYazili3;
        private System.Windows.Forms.TextBox txtNotYazili2;
        private System.Windows.Forms.TextBox txtNotYazili1;
        private System.Windows.Forms.TextBox txtNotDersKodu;
        private System.Windows.Forms.TextBox txtNotNumara;
        private System.Windows.Forms.Button btnNotSil;
        private System.Windows.Forms.Button btnNotGuncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

