using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
             int temp = int.Parse(textBox1.Text);
            if (temp <= 540000)
            { label3.Text = (temp * 0.05).ToString(); }

            else if (540001 <= temp && temp <= 1210000)

            { label3.Text = (temp*0.12-37800).ToString(); }

            else if (1210001 <= temp && temp <= 2420000)
            { label3.Text = (temp*0.2-96800-37800).ToString(); }

            else if (2420001 <= temp && temp <= 4530000)
            { label3.Text = (temp*0.3-242000-96800-37800).ToString(); }
            else if (4530000 <= temp && temp <= 10310000)
            { label3.Text = (temp * 0.4 - 453000 - 242000 - 96800 - 37800).ToString(); }
                else
            { label3.Text = (temp * 0.5 - 1031000 - 453000 - 242000 - 968000 - 37800).ToString(); }
        }
        
    }
}
