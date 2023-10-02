using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection
{
    public partial class Form1 : Form
    {
        private List<Mahasiswa> list = new List<Mahasiswa>();
        public Form1()
        {
            InitializeComponent();
            InisisalisasiListView();
            ResetForm();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvwmahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InisisalisasiListView()
        {
            lvwmahasiswa.View = View.Details;
            lvwmahasiswa.FullRowSelect = true;
            lvwmahasiswa.GridLines = true;

            lvwmahasiswa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwmahasiswa.Columns.Add("Nim", 50, HorizontalAlignment.Center);
            lvwmahasiswa.Columns.Add("Nama", 91, HorizontalAlignment.Center);
            lvwmahasiswa.Columns.Add("Kelas", 50, HorizontalAlignment.Center);
            lvwmahasiswa.Columns.Add("Nilai", 70, HorizontalAlignment.Center);
            lvwmahasiswa.Columns.Add("Nilai Huruf.", 120, HorizontalAlignment.Center);

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }
        private void ResetForm()
        {
            txtnim.Clear();
            txtnama.Clear();
            txtkelas.Clear();
            txtnilai.Text = "0";
            txtnim.Focus();
        }

     
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            // membuat objek mahasiswa 
            Mahasiswa mhs = new Mahasiswa();
            // set nilai masing-masing propertynya
            // berdasarkan inputan yang ada di form
            mhs.Nim = txtnim.Text;
            mhs.Nama = txtnama.Text;
            mhs.Kelas = txtkelas.Text;
            mhs.Nilai = int.Parse(txtnilai.Text);
            if (mhs.Nilai >= 0 && mhs.Nilai <= 20)
            {
                mhs.nilaiHuruf = "E";
            }
            else if (mhs.Nilai >= 21 && mhs.Nilai <= 40)
            {
                mhs.nilaiHuruf = "D";
            }
            else if (mhs.Nilai >= 41 && mhs.Nilai <= 60)
            {
                mhs.nilaiHuruf = "C";
            }
            else if (mhs.Nilai >= 61 && mhs.Nilai <= 80)
            {
                mhs.nilaiHuruf = "B";
            }
            else if (mhs.Nilai >= 81 && mhs.Nilai <= 100)
            {
                mhs.nilaiHuruf = "A";
            }

            list.Add(mhs);

            var msg = "Data mahasiswa berhasil disimpan.";

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ResetForm();
    }

    private void btntampilkandata_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void TampilkanData()
        {
            // kosongkan data listview
            lvwmahasiswa.Items.Clear();
            // lakukan perulangan untuk menampilkan data mahasiswa ke listview
            foreach (var mhs in list)
            {
                var noUrut = lvwmahasiswa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Nim);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Kelas);
                item.SubItems.Add(mhs.Nilai.ToString());
                item.SubItems.Add(mhs.nilaiHuruf);
                lvwmahasiswa.Items.Add(item);
            }
        }


        private void btnhapus_Click(object sender, EventArgs e)
        {

        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            // cek apakah data mahasiswa sudah dipilih
            if (lvwmahasiswa.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus ? ", "Konfirmasi",

                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index list yang di pilih
                    var index = lvwmahasiswa.SelectedIndices[0];
                    // hapus objek mahasiswa dari list
                    list.RemoveAt(index);
                    // refresh tampilan listivew
                    TampilkanData();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
