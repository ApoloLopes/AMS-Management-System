using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class PlantsDashboard : Form
    {
        public PlantsDashboard()
        {
            InitializeComponent();
        }

        private void PlantsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void MonitoringButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var monitor = new Monitoring();
            monitor.Closed += (s, args) => this.Close();
            monitor.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
