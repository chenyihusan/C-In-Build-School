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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {
        var context = new ContactsModel();//承上啟下
        var list = context.ContactsTable.ToList();//tolist載回來
        dataGridView1.DataSource=list;

}

    }
}
