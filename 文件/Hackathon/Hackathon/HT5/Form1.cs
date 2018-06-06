using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT5
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }
        public string GetAtomFromBirthday(DateTime dateTimePicker1)
        {

            float fBirthDay = Convert.ToSingle(dateTimePicker1.ToString("M.dd"));
            float[] atomBound = { 1.20F, 2.20F, 3.21F, 4.21F, 5.21F, 6.22F, 7.23F, 8.23F, 9.23F, 10.23F, 11.21F, 12.22F };
            string[] atoms = { "水瓶座", "雙魚座", "牡羊座", "金牛座", "雙子座", "巨蟹座", "獅子座", "處女座", "天秤座", "天蠍座", "射手座", "魔羯座" };
            string ret = string.Empty;

            for (int i = 0; i < atomBound.Length - 1; i++)
            {
                if (atomBound[i] <= fBirthDay && atomBound[i + 1] > fBirthDay)
                {
                    ret = atoms[i];
                    break;
                }

            }
            label3.Text = ret;
            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            label6.Text = GetAtomFromBirthday(dateTimePicker1.Value);


            string value = date.Year.ToString() + date.Month.ToString() + date.Day.ToString();
            int r = 0;
            for (int i = 0; i < value.Length; i++)
            {
                r += Convert.ToInt32(value.Substring(i, 1));

            }
            while (r > 9)
            {
                int tep = 0;
                string s1 = r.ToString();
                for (int i = 0; i < s1.Length; i++)
                {
                    tep += Convert.ToInt32(s1.Substring(i, 1));
                }
                r = tep;
            }

            label4.Text = r.ToString();

            string input = label3.Text;

            var result = new Dictionary<int, string>();
            switch (input)

            {
                case "水瓶座":
                    result = Star.CreateAquarius();
                    string key = result[r];
                    label3.Text = key;
                    break;
                case "雙魚座":
                    result = Star.CreatePieces();
                    string key1 = result[r];
                    label3.Text = key1;
                    break;
                case "白羊座":
                    result = Star.CreateAries();
                    string key2 = result[r];
                    label3.Text = key2;
                    break;
                case "金牛座":
                    result = Star.CreateTaurus();
                    string key3 = result[r];
                    label3.Text = key3;
                    break;
                case "雙子座":
                    result = Star.CreateGemini();
                    string key4 = result[r];
                    label3.Text = key4;
                    break;
                case "巨蟹座":
                    result = Star.CreateCancer();
                    string key5 = result[r];
                    label3.Text = key5;
                    break;
                case "獅子座":
                    result = Star.CreateLeo();
                    string key6 = result[r];
                    label3.Text = key6;
                    break;
                case "處女座":
                    result = Star.CreateVirgo();
                    string key7 = result[r];
                    label3.Text = key7;
                    break;
                case "天秤座":
                    result = Star.CreateLibra();
                    string key8 = result[r];
                    label3.Text = key8;
                    break;
                case "天蠍座":
                    result = Star.CreateScorpio();
                    string key9 = result[r];
                    label3.Text = key9;
                    break;
                case "射手座":
                    result = Star.CreateSagittarius();
                    string key0 = result[r];
                    label3.Text = key0;
                    break;
                case "魔羯座":
                    result = Star.CreateCapricorn();
                    string key11 = result[r];
                    label3.Text = key11;
                    break;
            }
        }




    }
}
        
    

    




    

