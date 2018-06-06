using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime  intime =new DateTime (dateTimePicker1.Value.Year,dateTimePicker1.Value.Month,dateTimePicker1.Value.Day,dateTimePicker1.Value.Hour,dateTimePicker1.Value.Minute,0);
            DateTime outtime = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, 0);
            label4.Text = $"{(outtime - intime).TotalMinutes.ToString()}分鐘";
            int Total = (int)(outtime - intime).TotalMinutes;
            int min = Total / 30;
            if (Total < 120)
            {
                label6.Text = $"${(min*30).ToString()}" ;
            }
            else if (Total >= 120 && Total < 240)
            {
                label6.Text = $"${(min * 40).ToString()}";
            }
            else
            {
                label6.Text = $"${(min * 60).ToString()}"; ;

            }

        }
    }
}
