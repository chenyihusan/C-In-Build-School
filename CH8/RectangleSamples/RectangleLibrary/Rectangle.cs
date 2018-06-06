using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary
{
    /// <summary>
    /// 自動實作屬性的寫法, C# 3.0(含以後支援)
    /// </summary>
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }


    /// <summary>
    /// 傳統的寫法 
    /// </summary>
    //public class Rectangle
    //{
    //    private int _width;
    //    public int Width
    //    {
    //        get { return _width; }
    //        set { _width = value; }
    //    }

    //    private int _height;
    //    public int Height
    //    {
    //        get { return _height; }
    //        set { _height = value; }
    //    }
    //}
}
