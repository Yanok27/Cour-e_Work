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
    public partial class BusAdd : Form
    {
        public BusAdd()
        {
            InitializeComponent();
        }

        private Bus bus;

        private void button1_Click(object sender, EventArgs e)
        {
            DbService db = new DbService();
            bus = new Bus();
            bus.Model = BusModelTB.Text;
            bus.Number = Int32.Parse(BusNoTB.Text);
            bus.PlaceCount = Int32.Parse(PlaceCountTB.Text);
            db.Buses.Load();
            db.Buses.Local.Add(bus);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
