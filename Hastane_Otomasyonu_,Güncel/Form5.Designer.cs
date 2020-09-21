namespace Hastane_Otomasyonu__Güncel
{
    partial class Form5
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
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.tbxKayıtSilGüncelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxHastaAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.hastaneOtomasyonuGüncelDataSet = new Hastane_Otomasyonu__Güncel.HastaneOtomasyonuGüncelDataSet();
            this.hastaBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaBilgileriTableAdapter = new Hastane_Otomasyonu__Güncel.HastaneOtomasyonuGüncelDataSetTableAdapters.HastaBilgileriTableAdapter();
            this.hastaIslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaIslemleriTableAdapter = new Hastane_Otomasyonu__Güncel.HastaneOtomasyonuGüncelDataSetTableAdapters.HastaIslemleriTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaIslemleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnKayitSil);
            this.groupBox1.Controls.Add(this.tbxKayıtSilGüncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxHastaAra);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(548, 35);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(71, 20);
            this.btnKayitSil.TabIndex = 5;
            this.btnKayitSil.Text = "KAYIT SİL";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxKayıtSilGüncelle
            // 
            this.tbxKayıtSilGüncelle.Location = new System.Drawing.Point(389, 35);
            this.tbxKayıtSilGüncelle.Name = "tbxKayıtSilGüncelle";
            this.tbxKayıtSilGüncelle.Size = new System.Drawing.Size(140, 20);
            this.tbxKayıtSilGüncelle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TCKN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta Ara";
            // 
            // tbxHastaAra
            // 
            this.tbxHastaAra.Location = new System.Drawing.Point(83, 35);
            this.tbxHastaAra.Name = "tbxHastaAra";
            this.tbxHastaAra.Size = new System.Drawing.Size(166, 20);
            this.tbxHastaAra.TabIndex = 1;
            this.tbxHastaAra.TextChanged += new System.EventHandler(this.tbxHastaAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(6, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HastaBilgileri.TCKN";
            this.Column1.HeaderText = "TCKN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HastaBilgileri.HastaAdi";
            this.Column2.HeaderText = "Hasta Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HastaBilgileri.HastaSoyadi";
            this.Column3.HeaderText = "Hasta Soyadı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HastaBilgileri.HastaYas";
            this.Column4.HeaderText = "Hasta Yaş";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HastaBilgileri.HastaKanGrubu";
            this.Column5.HeaderText = "KanGrubu";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HastaBilgileri.HastaCinsiyet";
            this.Column6.HeaderText = "Cinsiyet";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SevkTarihi";
            this.Column7.HeaderText = "Sevk Tarihi";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CıkısTarihi";
            this.Column8.HeaderText = "Çıkış Tarihi";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ToplamTutar";
            this.Column9.HeaderText = "Toplam Tutar";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "HastaBilgileri.HastaTelefonNumarasi";
            this.Column10.HeaderText = "Telefon Numarası";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "HastaBilgileri.HastaAdres";
            this.Column11.HeaderText = "Adres";
            this.Column11.Name = "Column11";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // hastaneOtomasyonuGüncelDataSet
            // 
            this.hastaneOtomasyonuGüncelDataSet.DataSetName = "HastaneOtomasyonuGüncelDataSet";
            this.hastaneOtomasyonuGüncelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgileriBindingSource
            // 
            this.hastaBilgileriBindingSource.DataMember = "HastaBilgileri";
            this.hastaBilgileriBindingSource.DataSource = this.hastaneOtomasyonuGüncelDataSet;
            // 
            // hastaBilgileriTableAdapter
            // 
            this.hastaBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // hastaIslemleriBindingSource
            // 
            this.hastaIslemleriBindingSource.DataMember = "HastaIslemleri";
            this.hastaIslemleriBindingSource.DataSource = this.hastaneOtomasyonuGüncelDataSet;
            // 
            // hastaIslemleriTableAdapter
            // 
            this.hastaIslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuGüncelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaIslemleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxKayıtSilGüncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxHastaAra;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnKayitSil;
        private HastaneOtomasyonuGüncelDataSet hastaneOtomasyonuGüncelDataSet;
        private System.Windows.Forms.BindingSource hastaBilgileriBindingSource;
        private HastaneOtomasyonuGüncelDataSetTableAdapters.HastaBilgileriTableAdapter hastaBilgileriTableAdapter;
        private System.Windows.Forms.BindingSource hastaIslemleriBindingSource;
        private HastaneOtomasyonuGüncelDataSetTableAdapters.HastaIslemleriTableAdapter hastaIslemleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}