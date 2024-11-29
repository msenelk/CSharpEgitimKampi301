using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLocation.Text = db.Location.Count().ToString();
            #endregion

            #region Toplam Kapasite
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            #endregion

            #region Rehber Sayısı
            lblGuideCount.Text = db.Guide.Count().ToString();
            #endregion

            #region Ortalama Kapasite
            lblAvgCapacity.Text=db.Location.Average(x=> x.Capacity).ToString();
            #endregion

            #region Ortalama Tur Fiyatı
            decimal avgLocationpRrice = (decimal)db.Location.Average(x => x.Price); // Gelen veriyi decimal bir değişkene atadık ve decimal olarak cast ettik
            lblAvgLocationPrice.Text=Math.Round(avgLocationpRrice, 2).ToString(); // Matematik fonksiyonlarından round u kullanarak virgülden sonra kaç basamak alacağını belirledik ve string e çevirdik
            // lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString() + " ₺";
            #endregion

            #region Eklenen Son Ülke
            int lastCountrId = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x => x.LocationId == lastCountrId).Select(y => y.Country).FirstOrDefault();
            #endregion

            #region Kapadokya Tur Kapasitesi
            label11.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            #endregion

            #region Türkiye Turları Ortalama Kapasitesi
            lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();
            #endregion

            #region Roma Gezi Rehberinin İsmi
            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.Name + " " + y.Surname).FirstOrDefault().ToString();
            #endregion

            #region  En Yüksek Kapasiteli Tur
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
            #endregion

            #region En Pahalı Tur
            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text=db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();
            #endregion

            #region Ayşegül Çınarın Tur Sayısı
            var guidIdByNameAysegulCinar = db.Guide.Where(x => x.Name == "Ayşegül" && x.Surname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guidIdByNameAysegulCinar).Count().ToString();
            #endregion

        }
    }
}
