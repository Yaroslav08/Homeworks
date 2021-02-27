using System;
using System.Collections.Generic;
using System.Text;
namespace LW8._2
{
    public class SmartPhone : СolorScreenPhone
    {
        public bool IsSupportTouchScreen { get; set; }
        public int CountOfTouchs { get; set; }
        public int CountOfCameras { get; set; }
    }
}