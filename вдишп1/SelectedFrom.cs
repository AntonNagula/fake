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
    public partial class SelectedFrom : Form
    {
        ControllForm controll;
        public SelectedFrom(ControllForm controll)
        {
            InitializeComponent();
            this.controll = controll;
        }

        public void Print(List<Bus> Buses, List<Train> Trains)
        {
            PrintBus(Buses);
            PrintTrain(Trains);
        }
        private void PrintBus(List<Bus> Buses)
        {
            dataBus.RowCount = Buses.Count;
            dataBus.ColumnCount = 9;

            int i = 0;
            foreach (Bus b in Buses)
            {
                int j = 0;
                dataBus.Rows[i].Cells[j].Value = b.Price;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.StartPlace;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.EndPlace;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.StartTimy;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.BeginRailwayStation;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.EndRailwayStation;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.Startdate;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.wayTime;
                j++;

                dataBus.Rows[i].Cells[j].Value = b.Rais;
                j++;

                i++;
            }
        }
        private void PrintTrain(List<Train> Trains)
        {

            dataTrain.RowCount = Trains.Count;
            dataTrain.ColumnCount = 10;

            int i = 0;
            foreach (Train t in Trains)
            {
                int j = 0;
                dataTrain.Rows[i].Cells[j].Value = t.Price;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.StartPlace;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.EndPlace;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.StartTimy;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.BeginRailwayStation;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.EndRailwayStation;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.Startdate;
                j++;


                dataTrain.Rows[i].Cells[j].Value = t.EndTimy;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.tipyTicket;
                j++;

                dataTrain.Rows[i].Cells[j].Value = t.TrainNumber;
                j++;

                i++;
            }
        }        
        private void Clean(object sender, EventArgs e)
        {
            dataBus.RowCount = 0;
            dataTrain.RowCount = 0;
        }
        private void Back(object sender, EventArgs e)
        {
            this.Hide();
            ((Form1)controll.dictionary["Form1"]).Show();
        }
    }
}
