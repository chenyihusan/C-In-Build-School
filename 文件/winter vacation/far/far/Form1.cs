using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace far
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxDataSource();
            ChangeData();

        }
        private void CreateList()
        {
            _leftList = new List<string>
            {
                "農夫","狼","羊","草"
            };
            _rightList = new List<string>();

        }
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
            listBox1.DisplayMember = "MyData";
            listBox2.DisplayMember = "MyData";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("農夫"))
            {
                if ((string)listBox1.SelectedItem == "農夫")//在listbox1 中點選農夫的話 農夫的資料型態是字串 所以要改變listbox1的資料型態 
                {
                    //string item = (string)listBox1.SelectedItem;
                    _leftList.Remove("農夫");
                    _rightList.Add("農夫");
                    ChangeData();//呼叫changedata且執行 
                }
                else
                {
                    string item = (string)listBox1.SelectedItem;
                    _leftList.Remove(item);
                    _leftList.Remove("農夫");
                    _rightList.Add(item);
                    _rightList.Add("農夫");
                    ChangeData();

                }
                if (listBox1.Items.Contains("狼") && listBox1.Items.Contains("羊"))

                {
                    MessageBox.Show("狼把羊吃了");
                }
                else if (listBox1.Items.Contains("羊") && listBox1.Items.Contains("草"))
                {

                    MessageBox.Show("羊把草吃了");

                }
                if (listBox2.Items.Contains("狼") && listBox2.Items.Contains("羊") && listBox2.Items.Contains("草"))
                {
                    MessageBox.Show("過河成功");

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Contains("農夫"))
            {
                if ((string)listBox2.SelectedItem == "農夫")//在listbox1 中點選農夫的話 農夫的資料型態是字串 所以要改變listbox1的資料型態 
                {

                    _leftList.Add("農夫");
                    _rightList.Remove("農夫");
                    ChangeData();//呼叫changedata且執行 
                }
                else
                {
                    string item = (string)listBox2.SelectedItem;
                    _rightList.Remove(item);
                    _leftList.Add(item);
                    _rightList.Remove("農夫");
                    _leftList.Add("農夫");
                    ChangeData();
                }
                if (listBox2.Items.Contains("狼") && listBox2.Items.Contains("羊"))

                {
                    MessageBox.Show("狼把羊吃了");
                }
                else if (listBox2.Items.Contains("羊") && listBox2.Items.Contains("草"))
                {

                    MessageBox.Show("羊把草吃了");
                }
            }
        }
    }

}
   
