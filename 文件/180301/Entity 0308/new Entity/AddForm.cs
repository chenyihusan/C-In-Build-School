using new_Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_Entity
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable()// 先產生一筆資料 在記憶體裡 requir 一定要有資料
            {
                UserName = textBox1.Text.Trim(),
                Address = textBox2.Text.Trim(),
                Phone = textBox3.Text.Trim()
            };
            try
            {
                ContactsModel context = new ContactsModel(); //記憶體之間的橋樑
                context.ContactsTable.Add(data);
                context.SaveChanges();// 改變 資料 
                MessageBox.Show("存檔完成");
                ClearTextBoxes();

            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤{ex.ToString()}"); }//練習用 tostring出來 自己要看的  


        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
