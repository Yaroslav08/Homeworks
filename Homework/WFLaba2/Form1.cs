using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace WFLaba2
{
    public partial class Form1 : Form
    {
        private Button[] arrayOfButtons = new Button[16];
        private Random random = new Random();
        private List<int> numbers = new List<int>();
        private int i = 1;
        private int randomValue;
        private TabControl tbControl;
        private TabPage tbTask1;
        private Button btnRemove;
        private Button btnAdd;
        private ComboBox comboBox1;
        private TabPage tbTask2;
        private TextBox txtBox;
        private TextBox txtBoxResult;
        private Button button1;

        public Form1()
        {
            this.Init();
            int num1 = 1;
            foreach (Button btn in this.arrayOfButtons)
                this.numbers.Add(num1++);
            int num2 = 0;
            int num3 = 0;
            for (int index1 = 1; index1 < this.arrayOfButtons.Length + 1; ++index1)
            {
                this.button1 = new Button();
                Button button1 = this.button1;
                int num4 = num3;
                Size size = this.button1.Size;
                int width = size.Width;
                int x = num4 * width + 60;
                int num5 = (index1 - 1) % 4;
                size = this.button1.Size;
                int height = size.Height;
                int y = num5 * height + 30;
                Point point = new Point(x, y);
                button1.Location = point;
                int index2 = this.random.Next(this.numbers.Count - 1);
                this.button1.Name = this.numbers[index2].ToString();
                this.button1.Size = new Size(new Point(40, 20));
                this.button1.Text = this.numbers[index2].ToString();
                this.button1.Click += new EventHandler(this.btnArray_Click);
                this.numbers.RemoveAt(index2);
                num2 = index2 + 1;
                this.arrayOfButtons[index1 - 1] = this.button1;
                this.tbTask2.Controls.Add((Control)this.arrayOfButtons[index1 - 1]);
                if (index1 % 4 == 0)
                    ++num3;
            }
            int num6 = 1;
            foreach (Button btn in this.arrayOfButtons)
                this.numbers.Add(num6++);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == this.btnAdd.Name)
            {
                if (!(this.txtBox.Text != ""))
                    return;
                this.comboBox1.Items.Add((object)this.txtBox.Text);
                this.txtBox.Text = "";
            }
            else
            {
                if ((uint)this.comboBox1.Items.Count <= 0U)
                    return;
                this.comboBox1.Items.RemoveAt(this.comboBox1.Items.Count - 1);
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == this.i.ToString())
            {
                this.txtBoxResult.Text = "";
                (sender as Button).Visible = false;
                this.numbers.RemoveAt(this.numbers.IndexOf(this.i));
                foreach (Button btn in this.arrayOfButtons)
                {
                    if (btn.Visible)
                    {
                        this.randomValue = this.random.Next(this.numbers.Count);
                        Button button1 = btn;
                        int number = this.numbers[this.randomValue];
                        string str1 = number.ToString();
                        button1.Name = str1;
                        Button button2 = btn;
                        number = this.numbers[this.randomValue];
                        string str2 = number.ToString();
                        button2.Text = str2;
                        this.numbers.RemoveAt(this.randomValue);
                    }
                }
                for (int index = this.i + 1; index < this.arrayOfButtons.Length + 1; ++index)
                    this.numbers.Add(index);
                ++this.i;
            }
            else if (this.i != 1)
                this.ClearNumbers();
            if (this.i != 17)
                return;
            this.txtBoxResult.TextAlign = HorizontalAlignment.Center;
            this.txtBoxResult.Text = "Красава, your the best!";
            this.ClearNumbers();
        }

        private void ClearNumbers()
        {
            this.numbers.Clear();
            this.i = 1;
            for (int i = this.i; i < this.arrayOfButtons.Length + 1; ++i)
                this.numbers.Add(i);
            foreach (Button btn in this.arrayOfButtons)
            {
                if (!btn.Visible)
                    btn.Visible = true;
                this.randomValue = this.random.Next(this.numbers.Count - 1);
                Button button1 = btn;
                int number = this.numbers[this.randomValue];
                string str1 = number.ToString();
                button1.Name = str1;
                Button button2 = btn;
                number = this.numbers[this.randomValue];
                string str2 = number.ToString();
                button2.Text = str2;
                this.numbers.RemoveAt(this.randomValue);
            }
            for (int i = this.i; i < this.arrayOfButtons.Length + 1; ++i)
                this.numbers.Add(i);
        }
        private void Init()
        {
            this.tbControl = new TabControl();
            this.tbTask1 = new TabPage();
            this.txtBox = new TextBox();
            this.btnRemove = new Button();
            this.btnAdd = new Button();
            this.comboBox1 = new ComboBox();
            this.tbTask2 = new TabPage();
            this.txtBoxResult = new TextBox();
            this.button1 = new Button();
            this.tbControl.SuspendLayout();
            this.tbTask1.SuspendLayout();
            this.tbTask2.SuspendLayout();
            this.SuspendLayout();
            this.tbControl.Controls.Add((Control)this.tbTask1);
            this.tbControl.Controls.Add((Control)this.tbTask2);
            this.tbControl.Location = new Point(12, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new Size(380, 239);
            this.tbControl.TabIndex = 0;
            this.tbTask1.Controls.Add((Control)this.txtBox);
            this.tbTask1.Controls.Add((Control)this.btnRemove);
            this.tbTask1.Controls.Add((Control)this.btnAdd);
            this.tbTask1.Controls.Add((Control)this.comboBox1);
            this.tbTask1.Location = new Point(4, 22);
            this.tbTask1.Name = "tbTask1";
            this.tbTask1.Padding = new Padding(3);
            this.tbTask1.Size = new Size(372, 213);
            this.tbTask1.TabIndex = 0;
            this.tbTask1.Text = "Завдання 1";
            this.tbTask1.UseVisualStyleBackColor = true;
            this.txtBox.BackColor = Color.Coral;
            this.txtBox.Location = new Point(6, 9);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new Size(121, 20);
            this.txtBox.TabIndex = 3;
            this.btnRemove.ForeColor = Color.Goldenrod;
            this.btnRemove.Location = new Point(247, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new EventHandler(this.btn_Click);
            this.btnAdd.ForeColor = Color.DarkSlateBlue;
            this.btnAdd.Location = new Point(152, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btn_Click);
            this.comboBox1.BackColor = Color.Chocolate;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(6, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.tbTask2.Controls.Add((Control)this.txtBoxResult);
            this.tbTask2.Location = new Point(4, 22);
            this.tbTask2.Name = "tbTask2";
            this.tbTask2.Padding = new Padding(3);
            this.tbTask2.Size = new Size(372, 213);
            this.tbTask2.TabIndex = 1;
            this.tbTask2.Text = "Завдання 2";
            this.tbTask2.UseVisualStyleBackColor = true;
            this.txtBoxResult.BackColor = Color.LawnGreen;
            this.txtBoxResult.Location = new Point(119, 174);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new Size(147, 20);
            this.txtBoxResult.TabIndex = 0;
            this.button1.Location = new Point(30, 23);
            this.button1.Name = "button1";
            this.button1.Size = new Size(40, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(636, 399);
            this.Controls.Add((Control)this.tbControl);
            this.Name = nameof(Form1);
            this.Text = nameof(Form1);
            this.tbControl.ResumeLayout(false);
            this.tbTask1.ResumeLayout(false);
            this.tbTask1.PerformLayout();
            this.tbTask2.ResumeLayout(false);
            this.tbTask2.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
