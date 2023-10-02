namespace Collection
{
    partial class Form1
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
            this.a = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtkelas = new System.Windows.Forms.TextBox();
            this.txtnilai = new System.Windows.Forms.TextBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntampilkandata = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.lvwmahasiswa = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(43, 60);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(31, 13);
            this.a.TabIndex = 0;
            this.a.Text = "Nim :";
            this.a.Click += new System.EventHandler(this.label1_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(43, 113);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(39, 13);
            this.c.TabIndex = 1;
            this.c.Text = "Kelas :";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(43, 141);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(33, 13);
            this.d.TabIndex = 2;
            this.d.Text = "Nilai :";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(43, 87);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(41, 13);
            this.b.TabIndex = 4;
            this.b.Text = "Nama :";
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(95, 57);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(100, 20);
            this.txtnim.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(95, 87);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(174, 20);
            this.txtnama.TabIndex = 6;
            // 
            // txtkelas
            // 
            this.txtkelas.Location = new System.Drawing.Point(95, 113);
            this.txtkelas.Name = "txtkelas";
            this.txtkelas.Size = new System.Drawing.Size(100, 20);
            this.txtkelas.TabIndex = 7;
            // 
            // txtnilai
            // 
            this.txtnilai.Location = new System.Drawing.Point(95, 141);
            this.txtnilai.Name = "txtnilai";
            this.txtnilai.Size = new System.Drawing.Size(100, 20);
            this.txtnilai.TabIndex = 8;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(46, 179);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 9;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(127, 179);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwmahasiswa);
            this.groupBox1.Controls.Add(this.btnhapus);
            this.groupBox1.Controls.Add(this.btntampilkandata);
            this.groupBox1.Location = new System.Drawing.Point(284, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 352);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Mahasiswa\'";
            // 
            // btntampilkandata
            // 
            this.btntampilkandata.Location = new System.Drawing.Point(32, 30);
            this.btntampilkandata.Name = "btntampilkandata";
            this.btntampilkandata.Size = new System.Drawing.Size(95, 23);
            this.btntampilkandata.TabIndex = 12;
            this.btntampilkandata.Text = "Tampilkan Data";
            this.btntampilkandata.UseVisualStyleBackColor = true;
            this.btntampilkandata.Click += new System.EventHandler(this.btntampilkandata_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(133, 30);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 13;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // lvwmahasiswa
            // 
            this.lvwmahasiswa.HideSelection = false;
            this.lvwmahasiswa.Location = new System.Drawing.Point(32, 59);
            this.lvwmahasiswa.Name = "lvwmahasiswa";
            this.lvwmahasiswa.Size = new System.Drawing.Size(434, 273);
            this.lvwmahasiswa.TabIndex = 14;
            this.lvwmahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwmahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwmahasiswa_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtnilai);
            this.Controls.Add(this.txtkelas);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtnim);
            this.Controls.Add(this.b);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "               ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtkelas;
        private System.Windows.Forms.TextBox txtnilai;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwmahasiswa;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btntampilkandata;
    }
}

