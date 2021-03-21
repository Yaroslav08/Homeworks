using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLaba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Yaroslav Mudryk";
            Load += (sender, e) =>
              {
                  for (int i = 1; i <= 16; i++)
                  {
                      Button btn = new Button();
                      btn.Name = $"button{i}";
                      btn.Text = $"{i}";
                      btn.Size = new Size(40, 30);
                      btn.Click += buttonClick;
                      btn.Location = new Point(10, 30 * i);
                      Controls.Add(btn);
                  }
              };
        }




        private void buttonClick(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
        }

    }

    public class Some
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
