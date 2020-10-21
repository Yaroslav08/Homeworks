using System;
using System.Collections.Generic;
using System.Text;
namespace LW8._2
{
    public class ButtonPhone : BasePhone
    {
        public ButtonPhone()
        {
            AvailableSymbols.AddRange(new List<string>
            {
                "Enter",
                "Cancel",
                "*",
                "#"
            });
        }
    }
}