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
    public partial class DispatcherAdd : Form
    {
       
        public DispatcherAdd()
        {
            InitializeComponent();
        }
        private Dispatcher dispatcher;

        private void button1_Click(object sender, EventArgs e)
        {
            DbService db = new DbService();
            dispatcher = new Dispatcher();
            dispatcher.Name = NameTB.Text;
            dispatcher.BirthDate = BirthDateTB.Value.ToShortDateString();
            dispatcher.Address = AddressTB.Text;
            db.Dispatchers.Load();
            db.Dispatchers.Local.Add(dispatcher);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        
    }
}
