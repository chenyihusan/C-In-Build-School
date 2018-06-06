using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weeken
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            int input2 = input + 1911;
           DateTime StartDate = new DateTime(input2, 01, 01);
            DateTime endDate = new DateTime( input2,12,31);
            int Sa = 0;
            int Su = 0;
            while (StartDate <= endDate)
            {
                if (StartDate.DayOfWeek == DayOfWeek.Saturday)
                   
                {
                    Sa += 1;
                }

                if(StartDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    Su += 1;
               }
               StartDate = StartDate.AddDays(1);

            }
            label4.Text= Convert.ToString (Sa);
            label5.Text = Convert.ToString(Su);
           
           
        }
    }
}
