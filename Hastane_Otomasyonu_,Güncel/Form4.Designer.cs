namespace Hastane_Otomasyonu__Güncel
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxDoktor = new System.Windows.Forms.ComboBox();
            this.doktorBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuGüncelDataSet = new Hastane_Otomasyonu__Güncel.HastaneOtomasyonuGüncelDataSet();
            this.dtSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxPoliklinik = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxHastaId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxDosyaNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxTaburcuHastaTCKN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbxToplamTutar = new System.Windows.Forms.TextBox();
            this.tbxOdemeSekli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaburcuEt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxKaydet = new System.Windows.Forms.Button();
            this.cbxMedeniHal = new System.Windows.Forms.ComboBox();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxKanGrubu = new System.Windows.Forms.ComboBox();
            this.tbxHastaSoyadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.tbxTelefonNumarasi = new System.Windows.Forms.TextBox();
            this.tbxHastaYas = new System.Windows.Forms.TextBox();
            this.tbxHastaAdi = new System.Windows.Forms.TextBox();
            this.tbxTCKN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHastaYas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.polikliniklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polikliniklerTableAdapter = new Hastane_Otomasyonu__Güncel.HastaneOtomasyonuGüncelDataSetTableAdapters.PolikliniklerTableAdapter();
            this.hastaneOtomasyonuGüncelDataSet1 = new Hastane_Otomasyonu__Güncel.HastaneOtomasyonuGüncelDataSet1();
            this.hastaneOtomasyonuGüncelDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktorBilgileriTableAdapter = new Hastane_Otomasyonu__Güncel.HastaneOtomasyonuGüncelDataSetTableAdapters.DoktorBilgileriTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polikliniklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnGoruntule);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(36, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 327);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGoruntule.Location = new System.Drawing.Point(712, 116);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(145, 45);
            this.btnGoruntule.TabIndex = 15;
            this.btnGoruntule.Text = "HASTA GÖRÜNTÜLE";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.cbxDoktor);
            this.groupBox4.Controls.Add(this.dtSevkTarihi);
            this.groupBox4.Controls.Add(this.cbxPoliklinik);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.Kaydet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbxHastaId);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbxDosyaNo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(57, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 263);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giriş İşlemleri";
            // 
            // cbxDoktor
            // 
            this.cbxDoktor.DataSource = this.doktorBilgileriBindingSource;
            this.cbxDoktor.DisplayMember = "Id";
            this.cbxDoktor.FormattingEnabled = true;
            this.cbxDoktor.Location = new System.Drawing.Point(95, 150);
            this.cbxDoktor.Name = "cbxDoktor";
            this.cbxDoktor.Size = new System.Drawing.Size(136, 21);
            this.cbxDoktor.TabIndex = 4;
            this.cbxDoktor.ValueMember = "Id";
            this.cbxDoktor.SelectedIndexChanged += new System.EventHandler(this.cbxDoktor_SelectedIndexChanged);
            // 
            // doktorBilgileriBindingSource
            // 
            this.doktorBilgileriBindingSource.DataMember = "DoktorBilgileri";
            this.doktorBilgileriBindingSource.DataSource = this.hastaneOtomasyonuGüncelDataSet;
            // 
            // hastaneOtomasyonuGüncelDataSet
            // 
            this.hastaneOtomasyonuGüncelDataSet.DataSetName = "HastaneOtomasyonuGüncelDataSet";
            this.hastaneOtomasyonuGüncelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSevkTarihi
            // 
            this.dtSevkTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSevkTarihi.Location = new System.Drawing.Point(95, 192);
            this.dtSevkTarihi.Name = "dtSevkTarihi";
            this.dtSevkTarihi.Size = new System.Drawing.Size(136, 20);
            this.dtSevkTarihi.TabIndex = 5;
            // 
            // cbxPoliklinik
            // 
            this.cbxPoliklinik.DisplayMember = "PoliklinikAdi";
            this.cbxPoliklinik.FormattingEnabled = true;
            this.cbxPoliklinik.Location = new System.Drawing.Point(95, 71);
            this.cbxPoliklinik.Name = "cbxPoliklinik";
            this.cbxPoliklinik.Size = new System.Drawing.Size(136, 21);
            this.cbxPoliklinik.TabIndex = 2;
            this.cbxPoliklinik.ValueMember = "Id";
            this.cbxPoliklinik.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Doktor:";
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(140, 218);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(91, 23);
            this.Kaydet.TabIndex = 13;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "TCKN:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Sevk Tarihi:";
            // 
            // tbxHastaId
            // 
            this.tbxHastaId.Location = new System.Drawing.Point(95, 30);
            this.tbxHastaId.Name = "tbxHastaId";
            this.tbxHastaId.Size = new System.Drawing.Size(136, 20);
            this.tbxHastaId.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Poliklinik:";
            // 
            // tbxDosyaNo
            // 
            this.tbxDosyaNo.Location = new System.Drawing.Point(95, 113);
            this.tbxDosyaNo.Name = "tbxDosyaNo";
            this.tbxDosyaNo.Size = new System.Drawing.Size(136, 20);
            this.tbxDosyaNo.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Dosya No:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.tbxTaburcuHastaTCKN);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.dtCikisTarihi);
            this.groupBox3.Controls.Add(this.tbxToplamTutar);
            this.groupBox3.Controls.Add(this.tbxOdemeSekli);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnTaburcuEt);
            this.groupBox3.Location = new System.Drawing.Point(410, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 263);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taburcu İşlemleri";
            // 
            // tbxTaburcuHastaTCKN
            // 
            this.tbxTaburcuHastaTCKN.Location = new System.Drawing.Point(127, 30);
            this.tbxTaburcuHastaTCKN.Name = "tbxTaburcuHastaTCKN";
            this.tbxTaburcuHastaTCKN.Size = new System.Drawing.Size(125, 20);
            this.tbxTaburcuHastaTCKN.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "TCKN:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCikisTarihi.Location = new System.Drawing.Point(127, 64);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(125, 20);
            this.dtCikisTarihi.TabIndex = 2;
            // 
            // tbxToplamTutar
            // 
            this.tbxToplamTutar.Location = new System.Drawing.Point(127, 146);
            this.tbxToplamTutar.Name = "tbxToplamTutar";
            this.tbxToplamTutar.Size = new System.Drawing.Size(125, 20);
            this.tbxToplamTutar.TabIndex = 4;
            // 
            // tbxOdemeSekli
            // 
            this.tbxOdemeSekli.Location = new System.Drawing.Point(127, 106);
            this.tbxOdemeSekli.Name = "tbxOdemeSekli";
            this.tbxOdemeSekli.Size = new System.Drawing.Size(125, 20);
            this.tbxOdemeSekli.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Toplam Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödeme Şekli:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çıkış Tarihi:";
            // 
            // btnTaburcuEt
            // 
            this.btnTaburcuEt.Location = new System.Drawing.Point(157, 182);
            this.btnTaburcuEt.Name = "btnTaburcuEt";
            this.btnTaburcuEt.Size = new System.Drawing.Size(95, 21);
            this.btnTaburcuEt.TabIndex = 2;
            this.btnTaburcuEt.Text = "Taburcu Et";
            this.btnTaburcuEt.UseVisualStyleBackColor = true;
            this.btnTaburcuEt.Click += new System.EventHandler(this.btnTaburcuEt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.tbxKaydet);
            this.groupBox2.Controls.Add(this.cbxMedeniHal);
            this.groupBox2.Controls.Add(this.cbxCinsiyet);
            this.groupBox2.Controls.Add(this.dtDogumTarihi);
            this.groupBox2.Controls.Add(this.cbxKanGrubu);
            this.groupBox2.Controls.Add(this.tbxHastaSoyadi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxAdres);
            this.groupBox2.Controls.Add(this.tbxTelefonNumarasi);
            this.groupBox2.Controls.Add(this.tbxHastaYas);
            this.groupBox2.Controls.Add(this.tbxHastaAdi);
            this.groupBox2.Controls.Add(this.tbxTCKN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblHastaYas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTCKN);
            this.groupBox2.Location = new System.Drawing.Point(36, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Kayıt";
            // 
            // tbxKaydet
            // 
            this.tbxKaydet.Location = new System.Drawing.Point(776, 122);
            this.tbxKaydet.Name = "tbxKaydet";
            this.tbxKaydet.Size = new System.Drawing.Size(81, 22);
            this.tbxKaydet.TabIndex = 24;
            this.tbxKaydet.Text = "Kaydet";
            this.tbxKaydet.UseVisualStyleBackColor = true;
            this.tbxKaydet.Click += new System.EventHandler(this.tbxKaydet_Click);
            // 
            // cbxMedeniHal
            // 
            this.cbxMedeniHal.FormattingEnabled = true;
            this.cbxMedeniHal.Items.AddRange(new object[] {
            "Bekar",
            "Evli",
            "Dul"});
            this.cbxMedeniHal.Location = new System.Drawing.Point(516, 59);
            this.cbxMedeniHal.Name = "cbxMedeniHal";
            this.cbxMedeniHal.Size = new System.Drawing.Size(100, 21);
            this.cbxMedeniHal.TabIndex = 7;
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(296, 103);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cbxCinsiyet.TabIndex = 9;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDogumTarihi.Location = new System.Drawing.Point(722, 17);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(118, 20);
            this.dtDogumTarihi.TabIndex = 4;
            this.dtDogumTarihi.Value = new System.DateTime(2020, 8, 25, 13, 11, 35, 0);
            // 
            // cbxKanGrubu
            // 
            this.cbxKanGrubu.FormattingEnabled = true;
            this.cbxKanGrubu.Items.AddRange(new object[] {
            "ARh+",
            "BRh+",
            "ARh-",
            "BRh-",
            "0Rh+",
            "0Rh-"});
            this.cbxKanGrubu.Location = new System.Drawing.Point(296, 67);
            this.cbxKanGrubu.Name = "cbxKanGrubu";
            this.cbxKanGrubu.Size = new System.Drawing.Size(100, 21);
            this.cbxKanGrubu.TabIndex = 6;
            this.cbxKanGrubu.SelectedIndexChanged += new System.EventHandler(this.cbxKanGrubu_SelectedIndexChanged);
            // 
            // tbxHastaSoyadi
            // 
            this.tbxHastaSoyadi.Location = new System.Drawing.Point(84, 106);
            this.tbxHastaSoyadi.Name = "tbxHastaSoyadi";
            this.tbxHastaSoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbxHastaSoyadi.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Doğum Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hasta Soyadı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Medeni Hali:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cinsiyet:";
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(516, 96);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(324, 20);
            this.tbxAdres.TabIndex = 10;
            // 
            // tbxTelefonNumarasi
            // 
            this.tbxTelefonNumarasi.Location = new System.Drawing.Point(516, 21);
            this.tbxTelefonNumarasi.Name = "tbxTelefonNumarasi";
            this.tbxTelefonNumarasi.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefonNumarasi.TabIndex = 3;
            // 
            // tbxHastaYas
            // 
            this.tbxHastaYas.Location = new System.Drawing.Point(296, 24);
            this.tbxHastaYas.Name = "tbxHastaYas";
            this.tbxHastaYas.Size = new System.Drawing.Size(100, 20);
            this.tbxHastaYas.TabIndex = 2;
            // 
            // tbxHastaAdi
            // 
            this.tbxHastaAdi.Location = new System.Drawing.Point(84, 64);
            this.tbxHastaAdi.Name = "tbxHastaAdi";
            this.tbxHastaAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxHastaAdi.TabIndex = 5;
            // 
            // tbxTCKN
            // 
            this.tbxTCKN.Location = new System.Drawing.Point(84, 24);
            this.tbxTCKN.Name = "tbxTCKN";
            this.tbxTCKN.Size = new System.Drawing.Size(100, 20);
            this.tbxTCKN.TabIndex = 1;
            this.tbxTCKN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxTCKN_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kan Grubu:";
            // 
            // lblHastaYas
            // 
            this.lblHastaYas.AutoSize = true;
            this.lblHastaYas.Location = new System.Drawing.Point(231, 28);
            this.lblHastaYas.Name = "lblHastaYas";
            this.lblHastaYas.Size = new System.Drawing.Size(59, 13);
            this.lblHastaYas.TabIndex = 2;
            this.lblHastaYas.Text = "Hasta Yaş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Adı:";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(34, 31);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(39, 13);
            this.lblTCKN.TabIndex = 0;
            this.lblTCKN.Text = "TCKN:";
            // 
            // polikliniklerBindingSource
            // 
            this.polikliniklerBindingSource.DataMember = "Poliklinikler";
            this.polikliniklerBindingSource.DataSource = this.hastaneOtomasyonuGüncelDataSet;
            // 
            // polikliniklerTableAdapter
            // 
            this.polikliniklerTableAdapter.ClearBeforeFill = true;
            // 
            // hastaneOtomasyonuGüncelDataSet1
            // 
            this.hastaneOtomasyonuGüncelDataSet1.DataSetName = "HastaneOtomasyonuGüncelDataSet1";
            this.hastaneOtomasyonuGüncelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneOtomasyonuGüncelDataSet1BindingSource
            // 
            this.hastaneOtomasyonuGüncelDataSet1BindingSource.DataSource = this.hastaneOtomasyonuGüncelDataSet1;
            this.hastaneOtomasyonuGüncelDataSet1BindingSource.Position = 0;
            // 
            // doktorBilgileriTableAdapter
            // 
            this.doktorBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polikliniklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxMedeniHal;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.ComboBox cbxKanGrubu;
        private System.Windows.Forms.TextBox tbxHastaSoyadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.TextBox tbxTelefonNumarasi;
        private System.Windows.Forms.TextBox tbxHastaYas;
        private System.Windows.Forms.TextBox tbxHastaAdi;
        private System.Windows.Forms.TextBox tbxTCKN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHastaYas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Button tbxKaydet;
        private System.Windows.Forms.Button btnTaburcuEt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxToplamTutar;
        private System.Windows.Forms.TextBox tbxOdemeSekli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDosyaNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxHastaId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxPoliklinik;
        private System.Windows.Forms.DateTimePicker dtSevkTarihi;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTaburcuHastaTCKN;
        private HastaneOtomasyonuGüncelDataSet hastaneOtomasyonuGüncelDataSet;
        private System.Windows.Forms.BindingSource polikliniklerBindingSource;
        private HastaneOtomasyonuGüncelDataSetTableAdapters.PolikliniklerTableAdapter polikliniklerTableAdapter;
        private System.Windows.Forms.ComboBox cbxDoktor;
        private System.Windows.Forms.BindingSource hastaneOtomasyonuGüncelDataSet1BindingSource;
        private HastaneOtomasyonuGüncelDataSet1 hastaneOtomasyonuGüncelDataSet1;
        private System.Windows.Forms.BindingSource doktorBilgileriBindingSource;
        private HastaneOtomasyonuGüncelDataSetTableAdapters.DoktorBilgileriTableAdapter doktorBilgileriTableAdapter;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}