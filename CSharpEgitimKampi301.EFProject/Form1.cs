using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Name = txtAd.Text;
            guide.Surname = txtSoyad.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.Name = txtAd.Text;
            updateValue.Surname = txtSoyad.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi.", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnIdGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
