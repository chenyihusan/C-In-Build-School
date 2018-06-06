using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wv9
{
    public partial class Form1 : Form
    {
        private List<Ticket> Data { get; set; }
        public Form1()
        {
            InitializeComponent();
            Data = Price.GetTicketList();
           // radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calculator = new TicketCalculator();
            string start = comboBox1.SelectedItem.ToString();
            string end = comboBox2.SelectedItem.ToString();
            bool isToSouth = false;
            if (radioButton1.Checked)
            {
                isToSouth = true;
            }
            var result = calculator.GetFare(start, end, checkBox1.Checked, checkBox2.Checked, isToSouth);
            if (result.HasValue)
            {
                label3.Text = result.Fare.ToString();
            }
            else
            {
                label3.Text = "查無此起訖站";
            }
            if (radioButton1.Checked)
            {
                DocomboBox1action();
            }
            else
            {
                DocomboBox2action();
            }

        }
     private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
     {
            if (radioButton1.Checked)
            {
                DocomboBox1action();
            }
            else
            {
                DocomboBox2action();
            }

     }
        



        private void DocomboBox1action()
        {
           comboBox1.DataSource = Data.GroupBy((x) => x.StartStation).Select((x) => x.Key).ToList();
        }

        private void DocomboBox2action()
        {
            comboBox2.DataSource = Data.GroupBy((x) => x.EndStation).Select((x) => x.Key).ToList();
        }
        private void SetToSouthEndCombobox()
        {
            string start = GetStartStation();
            comboBox2.DataSource = Data.Where((x) => x.StartStation == start).Select((x) => x.EndStation).ToList();

        }
        private string GetStartStation()
        {
            return comboBox1.SelectedItem.ToString();
        }

        private void SetToNorthEndCombobox()
        {
            string start = GetStartStation();
            comboBox2.DataSource = Data.Where((x) => x.EndStation == start).Select((x) => x.StartStation).ToList();

        }

    }
}
