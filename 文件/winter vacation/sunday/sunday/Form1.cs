using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sunday
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataTime dt = new DataTime(2009);




            MessageBox.Show("星期六有" + "  天;"+
          "    星期天有" + "  天");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
            textBox1.TabIndex = 0;

        }

      
    }
}
