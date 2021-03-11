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

            Load += (sender, e) =>
              {
                  for (int i = 1; i <= 16; i++)
                  {
                      Button btn = new Button();
                      btn.Name = $"button{i}";
                      btn.Text = $"{i}";
                      btn.Size = new Size(30, 30);
                      btn.Location = new Point(10, 30 * i);
                      btn.Click += buttonClick;
                      Controls.Add(btn);
                  }
              };
        }




        private void buttonClick(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
        }

    }
}
