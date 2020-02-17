using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using вдишп1.Factory;
using вдишп1.Models;
using вдишп1.Extencions;
using Microsoft.VisualBasic.FileIO;
using вдишп1.Iterator;

namespace вдишп1
{
    public partial class Form1 : Form
    {
        TrainsCollection Enumerator;

        private List<Bus> Buses = new List<Bus>();
        private List<Train> Trains = new List<Train>();

        private List<Bus> SelectedBuses = new List<Bus>();
        private List<Train> SelectedTrains = new List<Train>();

        ControllForm controll;
        public Form1(ControllForm controll)
        {
            InitializeComponent();

            YearCombo.Items.AddRange(new string[] { "2020", "2021" });
            MonthCombo.Items.AddRange(new string[] { "1", "2","3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            DayCombo.Items.AddRange(DayArray());
            HourCombo.Items.AddRange(HourArray());

            this.controll = controll;
        }
        private string[] DayArray()
        {
            List<string> arr = new List<string>();
            for(int i=1;i<32;i++)
            {
                arr.Add(i.ToString());
            }
            return arr.ToArray();
        }
        private string[] HourArray()
        {
            List<string> arr = new List<string>();
            for (int i = 0; i < 24; i++)
            {
                arr.Add(i.ToString());
            }
            return arr.ToArray();
        }
        public void LoadSCV()
        {
            XDocument xdoc = XDocument.Load("transport.xml");
            XElement root = xdoc.Element("transport");
            XElement tranes = root.Element("Buses");

            foreach (XElement xe in root.Elements("bus").ToList())
            {
                Bus t = new Bus();
                t.Price = xe.Element("Price").Value;
                t.StartTimy = xe.Element("StartTimy").Value;
                t.BeginRailwayStation = xe.Element("BeginRailwayStation").Value;
                t.EndRailwayStation = xe.Element("EndRailwayStation").Value;
                t.EndPlace = xe.Element("EndPlace").Value;

                t.wayTime = xe.Element("wayTime").Value;
                t.Rais = xe.Element("Rais").Value;
            }
        }

        private void LoadXML(object sender, EventArgs e)
        {
            GetBusXML(new BusFactory());
            GetTrainXML(new TrainFactory());            
            
            PrintTrain(Trains);
            PrintBus(Buses);

            StartPlaceFiltr();
            EndPlaceFiltr();
        }
        private void StartPlaceFiltr()
        {
            List<string> list = Trains.Select(x => x.StartPlace).Distinct().ToList();
            list.AddRange(Buses.Select(x => x.StartPlace).Distinct());
            list = list.Distinct().ToList();
            comboBox2.Items.AddRange(list.ToArray());
        }
        private void EndPlaceFiltr()
        {
            List<string> list = Trains.Select(x => x.EndPlace).Distinct().ToList();
            list.AddRange(Buses.Select(x => x.EndPlace).Distinct());
            list = list.Distinct().ToList();
            comboBox1.Items.AddRange(list.ToArray());
        }
        private void GetTrainXML(AbstractFactory factory)
        {
            XDocument xdoc = XDocument.Load(@"C:\Users\Banderos\Desktop\универ\3 курс\6 семестр\вдишп\1 лаба\вдишп1\1.xml");
            XElement root = xdoc.Element("transport");
            XElement tranes = root.Element("tranes");


            foreach (XElement xe in tranes.Elements("trane").ToList())
            {
                Train t = (Train)factory.TypeTransport();
                t.Price = xe.Element("Price").Value;                
                t.StartPlace = xe.Element("StartPlace").Value;
                t.EndPlace = xe.Element("EndPlace").Value;
                t.StartTimy = xe.Element("StartTimy").Value;
                t.BeginRailwayStation = xe.Element("BeginRailwayStation").Value;
                t.EndRailwayStation = xe.Element("EndRailwayStation").Value;               
                t.Startdate = xe.Element("Startdate").Value;

                t.EndTimy = xe.Element("EndTimy").Value;
                t.tipyTicket = xe.Element("tipyTicket").Value;
                t.TrainNumber = xe.Element("TrainNumber").Value;

                Trains.Add(t);
            }

            Fulltrains(Trains);
        }
        private void GetBusXML(AbstractFactory factory)
        {
            XDocument xdoc = XDocument.Load(@"C:\Users\Banderos\Desktop\универ\3 курс\6 семестр\вдишп\1 лаба\вдишп1\1.xml");
            XElement root = xdoc.Element("transport");
            XElement Bus = root.Element("Buses");
            foreach (XElement xe in Bus.Elements("bus").ToList())
            {               
                Bus t = (Bus)factory.TypeTransport();
                t.Price = xe.Element("Price").Value;
                t.StartPlace = xe.Element("StartPlace").Value;
                t.EndPlace = xe.Element("EndPlace").Value;
                t.StartTimy = xe.Element("StartTimy").Value;
                t.BeginRailwayStation = xe.Element("BeginRailwayStation").Value;
                t.EndRailwayStation = xe.Element("EndRailwayStation").Value;
                t.Startdate = xe.Element("Startdate").Value;


                t.wayTime = xe.Element("wayTime").Value;
                t.Rais = xe.Element("Rais").Value;

                Buses.Add(t);
            }
        }

        private void GetTrainSCV(AbstractFactory factory)
        {
            using (TextFieldParser tfp = new TextFieldParser(@"C:\Users\Banderos\Desktop\универ\3 курс\6 семестр\вдишп\1 лаба\вдишп1\2.csv", Encoding.Default))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(";");
                

                tfp.ReadFields();
                while (!tfp.EndOfData)
                {
                    string[] data = tfp.ReadLine().Split(new char[] { ';' });

                    Train t = (Train)factory.TypeTransport();

                    t.Price = data[4];
                    t.StartPlace = data[0];
                    t.EndPlace = data[1];
                    t.StartTimy = data[6];
                    t.BeginRailwayStation = data[2];
                    t.EndRailwayStation = data[3];
                    t.Startdate = data[7];
                    t.EndTimy = data[8];
                    t.tipyTicket = data[9];
                    t.TrainNumber = data[5];

                    Trains.Add(t);
                }
            }
            Fulltrains(Trains);
        }
        private void GetBusSCV(AbstractFactory factory)
        {
            
            using (TextFieldParser tfp = new TextFieldParser(@"C:\Users\Banderos\Desktop\универ\3 курс\6 семестр\вдишп\1 лаба\вдишп1\3.csv", Encoding.Default))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(";");


                tfp.ReadFields();
                while (!tfp.EndOfData)
                {
                    string[] data = tfp.ReadLine().Split(new char[] { ';' });

                    Bus t = (Bus)factory.TypeTransport();

                    t.Price = data[4];
                    t.StartPlace = data[0];
                    t.EndPlace = data[1];
                    t.StartTimy = data[5];
                    t.BeginRailwayStation = data[2];
                    t.EndRailwayStation = data[3];
                    t.Startdate = data[6];
                    t.Rais = data[7];
                    t.wayTime = data[8];

                    Buses.Add(t);
                }
            }
        }

        private void Fulltrains(List<Train> trains)
        {
            Train[] Trains = new Train[trains.Count];
            int i = 0;
            foreach(Train t in trains)
            {
                Trains[i] = trains[i];
                i++;
            }

            Enumerator = new TrainsCollection(Trains);
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

        private void PrintTrain(TrainsCollection enumer)
        {
            dataTrain.RowCount = Trains.Count;
            dataTrain.ColumnCount = 10;

            int i = 0;
            foreach (Train t in enumer)
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
        private void Diagram(object sender, EventArgs e)
        {
            this.Hide();
            int[] trains = new int[3];
            trains[0] = NumberTrain(Trains, 0, 8);
            trains[1] = NumberTrain(Trains, 8, 16);
            trains[2] = NumberTrain(Trains, 16, 24);

            int[] buses = new int[3];
            buses[0] = Numberbus(Buses, 0, 8);
            buses[1] = Numberbus(Buses, 8, 16);
            buses[2] = Numberbus(Buses, 16, 24);

            
            ((Diagramm)controll.dictionary["Diagramm"]).Show();
            ((Diagramm)controll.dictionary["Diagramm"]).Show(trains,buses);
        }
        private int Numberbus(List<Bus> trans,int start,int end)
        {
            return Buses.Where(x => x.TimyStrict(start,end)).ToList().Count;
        }
        private int NumberTrain(List<Train> trans, int start, int end)
        {
            return Trains.Where(x => x.TimyStrict(start, end)).ToList().Count;
        }

        private void Filtr_Cliclk(object sender, EventArgs e)
        {            
            string startdate = DayCombo.SelectedItem.ToString() + "." + MonthCombo.SelectedItem.ToString() + "." + YearCombo.SelectedItem.ToString();
            string starttimy = HourCombo.SelectedItem.ToString();

            List<Bus> Busfiltr = Buses.Where(x=>
            x.EndPlace == comboBox1.SelectedItem.ToString() 
            && x.StartPlace == comboBox2.SelectedItem.ToString()
            && x.EqualsDate(startdate, starttimy)).ToList();

            List<Train> Trainfiltr = Trains.Where(x => 
            x.EndPlace == comboBox1.SelectedItem.ToString() 
            && x.StartPlace == comboBox2.SelectedItem.ToString()
            && x.EqualsDate(startdate, starttimy)).ToList();

            PrintBus(Busfiltr);
            PrintTrain(Trainfiltr);
        }

        private void Select_Click(object sender, EventArgs e)
        {            
            BusFactory factory = new BusFactory();
            for(int i=0;i<dataBus.SelectedRows.Count;i++)
            {
                int j = 0;
                Bus t = (Bus)factory.TypeTransport();

                t.Price = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;
                t.StartPlace = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;
                t.EndPlace = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;
                t.StartTimy = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;
                t.BeginRailwayStation = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;
                t.EndRailwayStation = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;
                t.Startdate = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;
                
                t.wayTime = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;

                t.Rais = (string)dataBus.SelectedRows[i].Cells[j].Value;
                j++;

                SelectedBuses.Add(t);
            }

            TrainFactory factorytrain = new TrainFactory();
            for (int i = 0; i < dataTrain.SelectedRows.Count; i++)
            {
                int j = 0;
                Train t = (Train)factorytrain.TypeTransport();

                t.Price = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.StartPlace = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.EndPlace = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.StartTimy = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.BeginRailwayStation = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.EndRailwayStation = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.Startdate = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;

                t.EndTimy = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.tipyTicket = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;
                t.TrainNumber = (string)dataTrain.SelectedRows[i].Cells[j].Value;
                j++;

                SelectedTrains.Add(t);
            }
        }

        private void Chosen_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((SelectedFrom)controll.dictionary["SelectedFrom"]).Show();
            ((SelectedFrom)controll.dictionary["SelectedFrom"]).Print(SelectedBuses,SelectedTrains);
        }

        private void GetCSV_Click(object sender, EventArgs e)
        {
            GetTrainSCV(new TrainFactory());
            GetBusSCV(new BusFactory());

            PrintTrain(Enumerator);
            PrintBus(Buses);

            StartPlaceFiltr();
            EndPlaceFiltr();
        }
    }
}
