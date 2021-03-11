using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;
using EasyModbus;

namespace AMS
{
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
            
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayChart MeterData = new kayChart(chart1, 60);
            MeterData.serieName = "Voltage A-N [v]";

            chart1.Series["Voltage A-N [v]"].Color = Color.OrangeRed;
            chart1.Series["Voltage A-N [v]"].BorderWidth = 3;

            chart1.Series["Voltage B-N [v]"].Color = Color.BlueViolet;
            chart1.Series["Voltage B-N [v]"].BorderWidth = 3;

            Task.Factory.StartNew(() =>
            {

                MeterData.updateChart(updateVoltage, 1000);

            });
        }
        private double updateVoltage(){

            ModbusClient modbusClient = new ModbusClient("169.254.0.100", 502);
            modbusClient.Connect();

            double value = ModbusClient.ConvertRegistersToFloat(modbusClient.ReadHoldingRegisters(3027, 2), ModbusClient.RegisterOrder.HighLow);
            modbusClient.Disconnect();
            return value;
        
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
