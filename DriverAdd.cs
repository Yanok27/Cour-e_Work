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
    public partial class DriverAdd : Form
    {
        private Driver driver;
        public DriverAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver = new Driver();
            driver.Name = NameTB.Text;
            driver.BirthDate = BirthDateTB.Value.ToShortDateString();
            driver.PassId = Convert.ToInt32(PassIdTB.Text);
            DbService db = new DbService();
            db.Drivers.Load();
            db.Drivers.Add(driver);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
