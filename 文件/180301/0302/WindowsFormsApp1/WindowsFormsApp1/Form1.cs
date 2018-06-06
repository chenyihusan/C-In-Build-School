using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //public delegate void SomeAction(string message);
    public partial class Form1 : Form
    {
        private Class1 obj;
        
        public Form1()
        {
            InitializeComponent();
            obj = new Class1();
            obj.XChanged += Obj_XChanged; ;

        }

        

        private void Obj_XChanged(object sender, EventArgs e)
        {
           MessageBox.Show("x的質改變了");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.X += 1;
           // string source = textBox1.Text;
           // int result;
           ////bool isParsed = int.TryParse(source, out result);
           // string message;
           // if (/*isParsed*/int.TryParse(source, out result))
           // {
           //     message = $"正確解析字串{source}為整數{result}";
           // }
           // else
           // {

           //     message = $"無法解析字串{source}只好回傳預設值{result}";
           // }
           // MessageBox.Show(message);
           //_____________________________________________________________________________________

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       

    }
}
