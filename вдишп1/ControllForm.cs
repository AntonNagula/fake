using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace вдишп1
{
    public partial class ControllForm : Form
    {
        public Dictionary<string, Form> dictionary = new Dictionary<string, Form>();
        public ControllForm()
        {
            InitializeComponent();
            dictionary.Add("Form1", new Form1(this));
            dictionary.Add("Diagramm", new Diagramm(this));
            dictionary.Add("SelectedFrom", new SelectedFrom(this));
        }

        private void TimeTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Form1)dictionary["Form1"]).Show();
        }

        private void DiagrammClick(object sender, EventArgs e)
        {
            this.Hide();
            ((Diagramm)dictionary["Diagramm"]).Show();
        }
    }
}
