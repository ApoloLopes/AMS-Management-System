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
    public partial class InitialField : Form
    {
        public InitialField()
        {
            InitializeComponent();
        }

        private void InitialField_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AvanteLogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new PlantsDashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }
    }
}
