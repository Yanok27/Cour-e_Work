using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusStation.Services;
using Course_work_Cash_Dispatcher.Models;
using Microsoft.EntityFrameworkCore;

namespace BusStation
{
    public partial class TripAdd : Form
    {
        private DbService db = new DbService();
        private BindingList<Bus> buses;
        private BindingList<Ticket> tickets;
        private BindingList<Dispatcher> dispatchers;
        private BindingList<Driver> drivers;
        private BindingList<Route> routes;
        private Trip trip;
        public TripAdd()
        {
            InitializeComponent();
            db.Buses.Load();
            buses = db.Buses.Local.ToBindingList();
            dataGridView1.DataSource = buses;

            db.Tickets.Load();
            tickets = db.Tickets.Local.ToBindingList();
            dataGridView2.DataSource = tickets;

            db.Dispatchers.Load();
            dispatchers = db.Dispatchers.Local.ToBindingList();
            dataGridView3.DataSource = dispatchers;

            db.Drivers.Load();
            drivers = db.Drivers.Local.ToBindingList();
            dataGridView4.DataSource = drivers;

            db.Routes.Load();
            routes = db.Routes.Local.ToBindingList();
            dataGridView5.DataSource = routes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trip = new Trip();
            trip.TripNumber = Convert.ToInt32(TripNoTB.Text);
            trip.Route = routes.First(x =>
                x.Id.Equals(Convert.ToInt32(dataGridView5.SelectedCells[0].Value)));
            trip.Ticket = tickets.First(x =>
                x.Id.Equals(Convert.ToInt32(dataGridView3.SelectedCells[0].Value)));
            trip.Dispatcher = dispatchers.First(x =>
                x.Id.Equals(Convert.ToInt32(dataGridView4.SelectedCells[0].Value)));
            trip.Driver = drivers.First(x =>
                x.Id.Equals(Convert.ToInt32(dataGridView5.SelectedCells[0].Value)));
            trip.Bus = buses.First(x =>
                x.Id.Equals(Convert.ToInt32(dataGridView2.SelectedCells[0].Value)));

            db.Trips.Load();
            db.Trips.Local.Add(trip);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        
    }
}
