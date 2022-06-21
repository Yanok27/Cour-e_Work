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
    public partial class TicketAdd : Form
    {
        Ticket ticket;
        public TicketAdd()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ticket = new Ticket();
            ticket.BuyTime = BuyTimeTB.Value.ToString();
            ticket.PassId = Convert.ToInt32(PassIdTB.Text);
            ticket.PassangerName = NameTB.Text;
            ticket.Place = Convert.ToInt32(PlaceTB.Text);
            ticket.Price = Convert.ToInt32(PriceTB.Text);
            ticket.Priv = PrivChB.Checked;
            DbService db = new DbService();
            db.Tickets.Load();
            db.Tickets.Local.Add(ticket);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        
    }
}
