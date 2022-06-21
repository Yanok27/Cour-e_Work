using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using BusStation.Services;
using Course_work_Cash_Dispatcher.Models;
using Microsoft.EntityFrameworkCore;

namespace BusStation
{
    public partial class Form1 : Form
    {
        private DbService db = new DbService();
        private BindingList<Bus> buses;
        private BindingList<Trip> trips;
        private BindingList<Ticket> tickets;
        private BindingList<Dispatcher> dispatchers;
        private BindingList<Driver> drivers;
        private BindingList<Route> routes;

        public Form1()
        {
            InitializeComponent();

            db.Trips.Load();
            trips = db.Trips.Local.ToBindingList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = trips;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                DataPropertyName = "Id"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TripNumber",
                DataPropertyName = "TripNumber"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Destination",
                DataPropertyName = "Destination"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "StartTime",
                DataPropertyName = "StartTime"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "EndTime",
                DataPropertyName = "EndTime"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Place",
                DataPropertyName = "Place"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                DataPropertyName = "Name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                DataPropertyName = "Price"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DriverName",
                DataPropertyName = "DriverName"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DispatcherName",
                DataPropertyName = "DispatcherName"
            });



            db.Buses.Load();
            buses = db.Buses.Local.ToBindingList();
            dataGridView2.DataSource = buses;

            db.Tickets.Load();
            tickets = db.Tickets.Local.ToBindingList();
            dataGridView3.DataSource = tickets;

            db.Dispatchers.Load();
            dispatchers = db.Dispatchers.Local.ToBindingList();
            dataGridView4.DataSource = dispatchers;

            db.Drivers.Load();
            drivers = db.Drivers.Local.ToBindingList();
            dataGridView5.DataSource = drivers;

            db.Routes.Load();
            routes = db.Routes.Local.ToBindingList();
            dataGridView6.DataSource = routes;
        }

        private void AddSomeBtn_Click(object sender, EventArgs e)
        {
            Form addForm = null;
            switch (tabControl1.SelectedTab.Text)
            {
                case "Автобуси":
                    addForm = new BusAdd();
                    addForm.ShowDialog();
                    if (addForm.DialogResult == DialogResult.OK)
                    {
                        db.Buses.Load();
                    }

                    break;
                case "Білети":
                    addForm = new TicketAdd();
                    addForm.ShowDialog();
                    if (addForm.DialogResult == DialogResult.OK)
                    {
                        db.Tickets.Load();

                    }

                    break;
                case "Диспечери":
                    addForm = new DispatcherAdd();
                    addForm.ShowDialog();
                    if (addForm.DialogResult == DialogResult.OK)
                    {
                        db.Dispatchers.Load();
                    }

                    break;
                case "Водії":
                    addForm = new DriverAdd();
                    addForm.ShowDialog();
                    if (addForm.DialogResult == DialogResult.OK)
                    {
                        db.Drivers.Load();
                    }

                    break;
                case "Маршрути":
                    addForm = new RouteAdd();
                    addForm.ShowDialog();
                    if (addForm.DialogResult == DialogResult.OK)
                    {
                        db.Routes.Load();
                    }

                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Ви впевненні у своєму виборі?", "Видалення рядка", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                switch (tabControl1.SelectedTab.Text)
                {
                    case "Автобуси":
                        db.Buses.Local.Remove(buses.First(x =>
                            x.Id.Equals(Convert.ToInt32(dataGridView2.SelectedCells[0].Value))));
                        break;
                    case "Білети":
                        db.Tickets.Local.Remove(tickets.First(x =>
                            x.Id.Equals(Convert.ToInt32(dataGridView3.SelectedCells[0].Value))));
                        break;
                    case "Диспечери":
                        db.Dispatchers.Local.Remove(dispatchers.First(x =>
                            x.Id.Equals(Convert.ToInt32(dataGridView4.SelectedCells[0].Value))));
                        break;
                    case "Водії":
                        db.Drivers.Local.Remove(drivers.First(x =>
                            x.Id.Equals(Convert.ToInt32(dataGridView5.SelectedCells[0].Value))));
                        break;
                    case "Маршрути":
                        db.Routes.Local.Remove(routes.First(x =>
                            x.Id.Equals(Convert.ToInt32(dataGridView6.SelectedCells[0].Value))));
                        break;
                }
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form addForm = new TripAdd();
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK) db.Trips.Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Ви впевненні у своєму виборі?", "Видалення рядка", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                db.Trips.Local.Remove(trips.First(x =>
                    x.Id.Equals(Convert.ToInt32(dataGridView1.SelectedCells[0].Value))));
                db.SaveChanges();
            }
        }

        
    }
}