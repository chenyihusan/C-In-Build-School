using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1
    {
        public event EventHandler XChanged;
        public void OnXChanged()
        {
            if (XChanged != null)
            {
                XChanged.Invoke(this, new EventArgs());
                
            }
        }
        private int _X;
        public int X
        {
            get { return _X; }
            set
            {
                if (_X!= value)
                {
                    _X = value;
                    OnXChanged();//XChanged?.Invoke(this,new EventArgs()); 如果不是null才繼續做 invoke 
                }
            }
        }
    }
}
