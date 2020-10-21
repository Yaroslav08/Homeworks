using System;
using System.Collections.Generic;
using System.Text;
namespace LW8._2
{
    public class BasePhone
    {
        public string Number { get; set; }
        public List<string> AvailableSymbols = new List<string>
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
        };
    }
}