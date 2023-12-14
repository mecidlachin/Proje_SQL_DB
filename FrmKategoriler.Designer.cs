namespace Proje_SQL_DB
{
    partial class FrmKategoriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategoriler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKategoriID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtKategoriID
            // 
            this.txtKategoriID.Location = new System.Drawing.Point(128, 70);
            this.txtKategoriID.Name = "txtKategoriID";
            this.txtKategoriID.Size = new System.Drawing.Size(156, 27);
            this.txtKategoriID.TabIndex = 1;
            this.txtKategoriID.TextChanged += new System.EventHandler(this.txtKategoriID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Ad :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(128, 107);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(156, 27);
            this.txtKategoriAd.TabIndex = 3;
            this.txtKategoriAd.TextChanged += new System.EventHandler(this.txtKategoriAd_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnListele
            // 
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(363, 25);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(197, 36);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(363, 71);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(197, 36);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(315, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(363, 118);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(197, 36);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(315, 166);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(363, 166);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(197, 36);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(572, 434);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategoriID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKategoriID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnGuncelle;
    }
}