using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusStation.Services;
using Course_work_Cash_Dispatcher.Models;

namespace BusStation
{
    public partial class RouteAdd : Form
    {
        private Route route;
        public RouteAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            route = new Route();
            route.Destination = DestinationTB.Text;
            route.Distance = Convert.ToInt32(DistanceTB.Text);
            route.District = DistrictTB.Text;
            route.EndTime = EndDateTB.Value.ToShortTimeString();
            route.StartTime = StartDateTB.Value.ToShortTimeString();
            route.Importance = Convert.ToInt32(ImportanceTB.Text);
            route.Region = RegionTB.Text;
            route.RouteNumber = Convert.ToInt32(RouteNoTB.Text);
            DbService db = new DbService();
            db.Routes.Load();
            db.Routes.Local.Add(route);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

       
    }
}
