using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_EFProject
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
			lblLocationCount.Text = db.Location.Count().ToString();
			lblLocationCount.Location = new Point((panel1.Width - lblLocationCount.Width) / 2, lblLocationCount.Location.Y);

			lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
			lblSumCapacity.Location = new Point((panel1.Width - lblSumCapacity.Width) / 2, lblSumCapacity.Location.Y);

			lblGuideCount.Text = db.Guide.Count().ToString();
			lblGuideCount.Location = new Point((panel1.Width - lblGuideCount.Width) / 2, lblGuideCount.Location.Y);

			lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
			lblAvgCapacity.Location = new Point((panel1.Width - lblAvgCapacity.Width) / 2, lblAvgCapacity.Location.Y);

			lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString() + " ₺";
			lblAvgLocationPrice.Location = new Point((panel1.Width - lblAvgLocationPrice.Width) / 2, lblAvgLocationPrice.Location.Y);

			int lastCountryId = db.Location.Max(x => x.LocationId);
			lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
			lblLastCountryName.Location = new Point((panel1.Width - lblLastCountryName.Width) / 2, lblLastCountryName.Location.Y);

			lblKapadokyaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
			lblKapadokyaLocationCapacity.Location = new Point((panel1.Width - lblKapadokyaLocationCapacity.Width) / 2, lblKapadokyaLocationCapacity.Location.Y);

			lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
			lblTurkiyeCapacityAvg.Location = new Point((panel1.Width - lblTurkiyeCapacityAvg.Width) / 2, lblTurkiyeCapacityAvg.Location.Y);

			var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
			lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
			lblRomeGuideName.Location = new Point((panel1.Width - lblRomeGuideName.Width) / 2, lblRomeGuideName.Location.Y);

			var maxCapacity = db.Location.Max(x => x.Capacity);
			lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
			lblMaxCapacityLocation.Location = new Point((panel1.Width - lblMaxCapacityLocation.Width) / 2, lblMaxCapacityLocation.Location.Y);

			var maxPrice = db.Location.Max(x => x.Price);
			lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
			lblMaxPriceLocation.Location = new Point((panel1.Width - lblMaxPriceLocation.Width) / 2, lblMaxPriceLocation.Location.Y);

			var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
			lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
			lblAysegulCinarLocationCount.Location = new Point((panel1.Width - lblAysegulCinarLocationCount.Width) / 2, lblAysegulCinarLocationCount.Location.Y);
		}
	}
}
