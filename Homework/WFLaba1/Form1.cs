using System;
using System.Drawing;
using System.Windows.Forms;
namespace WFLaba1
{
    public partial class Form1 : Form
    {
        private double operand = 0.0;
        private double old_operand = 0.0;
        private bool fractional = false;
        private double rank = 1.0;
        private Form1.Action was_operation;
        private bool was_equal = false;
        private int sign = 1;
        private bool block_double_operation = false;
        private double operand_ = 0.0;
        private Form1.Action was_operation_;
        private bool not_first = false;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox textBox1;
        private Button button17;
        private Button button18;

        public Form1() => this.Init();

        private void button16_Click(object sender, EventArgs e) => this.addNumber(0);

        private void button12_Click(object sender, EventArgs e) => this.addNumber(1);

        private void button11_Click(object sender, EventArgs e) => this.addNumber(2);

        private void button10_Click(object sender, EventArgs e) => this.addNumber(3);

        private void button8_Click(object sender, EventArgs e) => this.addNumber(4);

        private void button7_Click(object sender, EventArgs e) => this.addNumber(5);

        private void button6_Click(object sender, EventArgs e) => this.addNumber(6);

        private void button1_Click(object sender, EventArgs e) => this.addNumber(7);

        private void button2_Click(object sender, EventArgs e) => this.addNumber(8);

        private void button3_Click(object sender, EventArgs e) => this.addNumber(9);

        private void addNumber(int N)
        {
            this.block_double_operation = false;
            this.not_first = false;
            if (this.was_equal)
                this.ClearAll();
            if (this.fractional)
            {
                this.rank /= 10.0;
                this.operand += (double)N * this.rank;
            }
            else
            {
                this.operand *= 10.0;
                this.operand += (double)N;
            }
            this.Opetand_to_indicator();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.rank = 1.0;
            this.fractional = true;
            this.Opetand_to_indicator();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.sign = -this.sign;
            if (this.operand == 0.0)
            {
                if (this.sign < 0)
                    this.textBox1.Text = "-";
                else
                    this.textBox1.Text = "";
            }
            else
                this.Opetand_to_indicator();
        }

        private void button13_Click(object sender, EventArgs e) => this.operation(Form1.Action.Addition);

        private void button9_Click(object sender, EventArgs e) => this.operation(Form1.Action.Subtraction);

        private void button5_Click(object sender, EventArgs e) => this.operation(Form1.Action.Multiplication);

        private void button4_Click(object sender, EventArgs e) => this.operation(Form1.Action.Division);

        private void operation(Form1.Action oper)
        {
            if (this.block_double_operation)
                return;
            this.block_double_operation = true;
            this.Equal();
            this.was_equal = false;
            this.was_operation = oper;
            this.old_operand = this.operand;
            this.fractional = false;
            this.operand = 0.0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (this.was_equal)
            {
                this.old_operand = this.operand;
                this.operand = this.operand_;
                this.was_operation = this.was_operation_;
            }
            this.was_equal = true;
            this.Equal();
            this.was_operation = Form1.Action.Empty;
        }

        private void Equal()
        {
            this.operand *= (double)this.sign;
            this.sign = 1;
            this.operand_ = this.operand;
            this.was_operation_ = this.was_operation;
            switch (this.was_operation)
            {
                case Form1.Action.Addition:
                    this.operand = this.old_operand + this.operand;
                    break;
                case Form1.Action.Subtraction:
                    this.operand = this.old_operand - this.operand;
                    break;
                case Form1.Action.Multiplication:
                    this.operand = this.old_operand * this.operand;
                    break;
                case Form1.Action.Division:
                    this.operand = this.old_operand / this.operand;
                    break;
            }
            this.old_operand = this.operand;
            this.Opetand_to_indicator();
            this.fractional = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (this.not_first)
            {
                this.ClearAll();
                this.not_first = false;
            }
            else
            {
                this.sign = 1;
                this.not_first = true;
                this.operand = 0.0;
                this.fractional = false;
            }
            this.Opetand_to_indicator();
        }

        private void ClearAll()
        {
            this.was_equal = false;
            this.operand = 0.0;
            this.was_operation = Form1.Action.Empty;
            this.old_operand = 0.0;
            this.fractional = false;
            this.sign = 1;
        }

        private void Opetand_to_indicator() => this.textBox1.Text = ((double)this.sign * this.operand).ToString("0.#########");

        private void Init()
        {
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.button10 = new Button();
            this.button11 = new Button();
            this.button12 = new Button();
            this.button13 = new Button();
            this.button14 = new Button();
            this.button15 = new Button();
            this.button16 = new Button();
            this.textBox1 = new TextBox();
            this.button17 = new Button();
            this.button18 = new Button();
            this.SuspendLayout();
            this.button1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button1.ForeColor = Color.Maroon;
            this.button1.Location = new Point(12, 85);
            this.button1.Name = "button1";
            this.button1.Size = new Size(32, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button2.ForeColor = Color.Maroon;
            this.button2.Location = new Point(50, 85);
            this.button2.Name = "button2";
            this.button2.Size = new Size(32, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button3.ForeColor = Color.Maroon;
            this.button3.Location = new Point(88, 85);
            this.button3.Name = "button3";
            this.button3.Size = new Size(32, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button4.ForeColor = Color.Maroon;
            this.button4.Location = new Point(126, 85);
            this.button4.Name = "button4";
            this.button4.Size = new Size(32, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.button5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button5.ForeColor = Color.Maroon;
            this.button5.Location = new Point(126, 122);
            this.button5.Name = "button5";
            this.button5.Size = new Size(32, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.button6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button6.ForeColor = Color.Maroon;
            this.button6.Location = new Point(88, 122);
            this.button6.Name = "button6";
            this.button6.Size = new Size(32, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new EventHandler(this.button6_Click);
            this.button7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button7.ForeColor = Color.Maroon;
            this.button7.Location = new Point(50, 122);
            this.button7.Name = "button7";
            this.button7.Size = new Size(32, 31);
            this.button7.TabIndex = 5;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new EventHandler(this.button7_Click);
            this.button8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button8.ForeColor = Color.Maroon;
            this.button8.Location = new Point(12, 122);
            this.button8.Name = "button8";
            this.button8.Size = new Size(32, 31);
            this.button8.TabIndex = 4;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new EventHandler(this.button8_Click);
            this.button9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button9.ForeColor = Color.Maroon;
            this.button9.Location = new Point(126, 159);
            this.button9.Name = "button9";
            this.button9.Size = new Size(32, 31);
            this.button9.TabIndex = 11;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new EventHandler(this.button9_Click);
            this.button10.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button10.ForeColor = Color.Maroon;
            this.button10.Location = new Point(88, 159);
            this.button10.Name = "button10";
            this.button10.Size = new Size(32, 31);
            this.button10.TabIndex = 10;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new EventHandler(this.button10_Click);
            this.button11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button11.ForeColor = Color.Maroon;
            this.button11.Location = new Point(50, 159);
            this.button11.Name = "button11";
            this.button11.Size = new Size(32, 31);
            this.button11.TabIndex = 9;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new EventHandler(this.button11_Click);
            this.button12.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button12.ForeColor = Color.Maroon;
            this.button12.Location = new Point(12, 159);
            this.button12.Name = "button12";
            this.button12.Size = new Size(32, 31);
            this.button12.TabIndex = 8;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new EventHandler(this.button12_Click);
            this.button13.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button13.ForeColor = Color.Maroon;
            this.button13.Location = new Point(126, 196);
            this.button13.Name = "button13";
            this.button13.Size = new Size(32, 31);
            this.button13.TabIndex = 15;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new EventHandler(this.button13_Click);
            this.button14.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button14.ForeColor = Color.Maroon;
            this.button14.Location = new Point(88, 196);
            this.button14.Name = "button14";
            this.button14.Size = new Size(32, 31);
            this.button14.TabIndex = 14;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new EventHandler(this.button14_Click);
            this.button15.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button15.ForeColor = Color.Maroon;
            this.button15.Location = new Point(50, 196);
            this.button15.Name = "button15";
            this.button15.Size = new Size(32, 31);
            this.button15.TabIndex = 13;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new EventHandler(this.button15_Click);
            this.button16.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button16.ForeColor = Color.Maroon;
            this.button16.Location = new Point(12, 196);
            this.button16.Name = "button16";
            this.button16.Size = new Size(32, 31);
            this.button16.TabIndex = 12;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new EventHandler(this.button16_Click);
            this.textBox1.BackColor = SystemColors.ControlDarkDark;
            this.textBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.textBox1.ForeColor = Color.GhostWhite;
            this.textBox1.Location = new Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(146, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = HorizontalAlignment.Right;
            this.button17.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button17.ForeColor = Color.Red;
            this.button17.Location = new Point(109, 48);
            this.button17.Name = "button17";
            this.button17.Size = new Size(49, 31);
            this.button17.TabIndex = 17;
            this.button17.Text = "C";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new EventHandler(this.button17_Click);
            this.button18.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            this.button18.ForeColor = Color.DarkRed;
            this.button18.Location = new Point(12, 48);
            this.button18.Name = "button18";
            this.button18.Size = new Size(50, 31);
            this.button18.TabIndex = 18;
            this.button18.Text = "+/-";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new EventHandler(this.button18_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(170, 238);
            this.Controls.Add((Control)this.button18);
            this.Controls.Add((Control)this.button17);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.button13);
            this.Controls.Add((Control)this.button14);
            this.Controls.Add((Control)this.button15);
            this.Controls.Add((Control)this.button16);
            this.Controls.Add((Control)this.button9);
            this.Controls.Add((Control)this.button10);
            this.Controls.Add((Control)this.button11);
            this.Controls.Add((Control)this.button12);
            this.Controls.Add((Control)this.button5);
            this.Controls.Add((Control)this.button6);
            this.Controls.Add((Control)this.button7);
            this.Controls.Add((Control)this.button8);
            this.Controls.Add((Control)this.button4);
            this.Controls.Add((Control)this.button3);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.button1);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = nameof(Form1);
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private enum Action
        {
            Empty,
            Addition,
            Subtraction,
            Multiplication,
            Division,
        }

    }
}
