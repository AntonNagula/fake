using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using вдишп1.Models;

namespace вдишп1
{
    public partial class Diagramm : Form
    {
        ControllForm controll;
        public Diagramm(ControllForm controll)
        {
            InitializeComponent();        

            this.controll = controll;

        }
        public void Show(int[] trains,int[] buses)
        {
            
            int K = 0;
            Trains.Series[0].Points.AddXY(K, trains[0]);
            Trains.Series[0].Points[K].LegendText = "00:00-08:00";

            K++;
            Trains.Series[0].Points.AddXY(K, trains[1]);
            Trains.Series[0].Points[K].LegendText = "08:00-16:00";

            K++;
            Trains.Series[0].Points.AddXY(K, trains[2]);
            Trains.Series[0].Points[K].LegendText = "16:00-24:00";

            K=0;
            Bus.Series[0].Points.AddXY(K, buses[0]);
            Bus.Series[0].Points[K].LegendText = "00:00-08:00";

            K++;
            Bus.Series[0].Points.AddXY(K, buses[1]);
            Bus.Series[0].Points[K].LegendText = "08:00-16:00";

            K++;
            Bus.Series[0].Points.AddXY(K, buses[2]);
            Bus.Series[0].Points[K].LegendText = "16:00-00:00";
        }
        private void TimeTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Form1)controll.dictionary["Form1"]).Show();
        }
    }
}
