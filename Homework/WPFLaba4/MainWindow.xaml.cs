using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLaba4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private double operand = 0.0;
        private double old_operand = 0.0;
        private bool fractional = false;
        private double rank = 1.0;
        private MainWindow.Action was_operation;
        private bool was_equal = false;
        private int sign = 1;
        private bool block_double_operation = false;
        private double operand_ = 0.0;
        private MainWindow.Action was_operation_;
        private bool not_first = false;
        private Grid grid;
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

        private void button13_Click(object sender, EventArgs e) => this.operation(MainWindow.Action.Addition);

        private void button9_Click(object sender, EventArgs e) => this.operation(MainWindow.Action.Subtraction);

        private void button5_Click(object sender, EventArgs e) => this.operation(MainWindow.Action.Multiplication);

        private void button4_Click(object sender, EventArgs e) => this.operation(MainWindow.Action.Division);

        private void operation(MainWindow.Action oper)
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
            this.was_operation = MainWindow.Action.Empty;
        }

        private void Equal()
        {
            this.operand *= (double)this.sign;
            this.sign = 1;
            this.operand_ = this.operand;
            this.was_operation_ = this.was_operation;
            switch (this.was_operation)
            {
                case MainWindow.Action.Addition:
                    this.operand = this.old_operand + this.operand;
                    break;
                case MainWindow.Action.Subtraction:
                    this.operand = this.old_operand - this.operand;
                    break;
                case MainWindow.Action.Multiplication:
                    this.operand = this.old_operand * this.operand;
                    break;
                case MainWindow.Action.Division:
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
            this.was_operation = MainWindow.Action.Empty;
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

            this.button1.FontSize = 12f;
            this.button1.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button1.Foreground = Brushes.Maroon;
            this.button1.Margin = new Thickness(12, 85, 0, 0);
            this.button1.Name = "button1";
            this.button1.Height =  31;
            this.button1.Width =  32;
            this.button1.TabIndex = 0;
            this.button1.Content = "7";
            this.button1.Click += this.button1_Click;

            this.button2.FontSize = 12f;
            this.button2.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button2.Foreground = Brushes.Maroon;
            this.button2.Margin = new Thickness(12, 85, 0, 0);
            this.button2.Name = "button2";
            this.button2.Height = 31;
            this.button2.Width = 32;
            this.button2.TabIndex = 1;
            this.button2.Content = "8";
            this.button2.Click += this.button2_Click;

            this.button3.FontSize = 12f;
            this.button3.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button3.Foreground = Brushes.Maroon;
            this.button3.Margin = new Thickness(88, 85, 0, 0);
            this.button3.Name = "button3";
            this.button3.Height = 31;
            this.button3.Width = 32;
            this.button3.TabIndex = 2;
            this.button3.Content = "9";
            this.button3.Click += this.button3_Click;

            this.button4.FontSize = 12f;
            this.button4.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button4.Foreground = Brushes.Maroon;
            this.button4.Margin = new Thickness(126, 85, 0, 0);
            this.button4.Name = "button4";
            this.button4.Height = 31;
            this.button4.Width = 32;
            this.button4.TabIndex = 3;
            this.button4.Content = "/";
            this.button4.Click += this.button4_Click;

            this.button5.FontSize = 12f;
            this.button5.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button5.Foreground = Brushes.Maroon;
            this.button5.Margin = new Thickness(126, 122, 0, 0);
            this.button5.Name = "button5";
            this.button5.Height = 31;
            this.button5.Width = 32;
            this.button5.TabIndex = 7;
            this.button5.Content = "*";
            this.button5.Click += this.button5_Click;

            this.button6.FontSize = 12f;
            this.button6.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button6.Foreground = Brushes.Maroon;
            this.button6.Margin = new Thickness(88, 122, 0, 0);
            this.button6.Name = "button6";
            this.button6.Height = 31;
            this.button6.Width = 32;
            this.button6.TabIndex = 6;
            this.button6.Content = "6";
            this.button6.Click += this.button6_Click;

            this.button7.FontSize = 12f;
            this.button7.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button7.Foreground = Brushes.Maroon;
            this.button7.Margin = new Thickness(50, 122, 0, 0);
            this.button7.Name = "button7";
            this.button7.Height = 31;
            this.button7.Width = 32;
            this.button7.TabIndex = 5;
            this.button7.Content = "5";
            this.button7.Click += this.button7_Click;

            this.button8.FontSize = 12f;
            this.button8.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button8.Foreground = Brushes.Maroon;
            this.button8.Margin = new Thickness(12, 122, 0, 0);
            this.button8.Name = "button7";
            this.button8.Height = 31;
            this.button8.Width = 32;
            this.button8.TabIndex = 4;
            this.button8.Content = "4";
            this.button8.Click += this.button8_Click;

            this.button9.FontSize = 12f;
            this.button9.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button9.Foreground = Brushes.Maroon;
            this.button9.Margin = new Thickness(126, 159, 0, 0);
            this.button9.Name = "button9";
            this.button9.Height = 31;
            this.button9.Width = 32;
            this.button9.TabIndex = 11;
            this.button9.Content = "-";
            this.button9.Click += this.button9_Click;

            this.button10.FontSize = 12f;
            this.button10.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button10.Foreground = Brushes.Maroon;
            this.button10.Margin = new Thickness(88, 159, 0, 0);
            this.button10.Name = "button10";
            this.button10.Height = 31;
            this.button10.Width = 32;
            this.button10.TabIndex = 10;
            this.button10.Content = "3";
            this.button10.Click += this.button10_Click;

            this.button11.FontSize = 12f;
            this.button11.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button11.Foreground = Brushes.Maroon;
            this.button11.Margin = new Thickness(50, 159, 0, 0);
            this.button11.Name = "button11";
            this.button11.Height = 31;
            this.button11.Width = 32;
            this.button11.TabIndex = 9;
            this.button11.Content = "2";
            this.button11.Click += this.button11_Click;

            this.button12.FontSize = 12f;
            this.button12.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button12.Foreground = Brushes.Maroon;
            this.button12.Margin = new Thickness(12, 159, 0, 0);
            this.button12.Name = "button12";
            this.button12.Height = 31;
            this.button12.Width = 32;
            this.button12.TabIndex = 8;
            this.button12.Content = "1";
            this.button12.Click += this.button12_Click;

            this.button13.FontSize = 12f;
            this.button13.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button13.Foreground = Brushes.Maroon;
            this.button13.Margin = new Thickness(126, 159, 0, 0);
            this.button13.Name = "button13";
            this.button13.Height = 31;
            this.button13.Width = 32;
            this.button13.TabIndex = 15;
            this.button13.Content = "+";
            this.button13.Click += this.button13_Click;

            this.button14.FontSize = 12f;
            this.button14.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button14.Foreground = Brushes.Maroon;
            this.button14.Margin = new Thickness(88, 196, 0, 0);
            this.button14.Name = "button14";
            this.button14.Height = 31;
            this.button14.Width = 32;
            this.button14.TabIndex = 14;
            this.button14.Content = "=";
            this.button14.Click += this.button14_Click;

            this.button15.FontSize = 12f;
            this.button15.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button15.Foreground = Brushes.Maroon;
            this.button15.Margin = new Thickness(50, 196, 0, 0);
            this.button15.Name = "button15";
            this.button15.Height = 31;
            this.button15.Width = 32;
            this.button15.TabIndex = 13;
            this.button15.Content = ".";
            this.button15.Click += this.button15_Click;

            this.button16.FontSize = 12f;
            this.button16.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button16.Foreground = Brushes.Maroon;
            this.button16.Margin = new Thickness(12, 196, 0, 0);
            this.button16.Name = "button16";
            this.button16.Height = 31;
            this.button16.Width = 32;
            this.button16.TabIndex = 12;
            this.button16.Content = "0";
            this.button16.Click += this.button16_Click;

            this.button17.FontSize = 12f;
            this.button17.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button17.Foreground = Brushes.Red;
            this.button17.Margin = new Thickness(109, 48, 0, 0);
            this.button17.Name = "button17";
            this.button17.Height = 31;
            this.button17.Width = 49;
            this.button17.TabIndex = 17;
            this.button17.Content = "C";
            this.button17.Click += this.button17_Click;

            this.button18.FontSize = 12f;
            this.button18.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.button18.Foreground = Brushes.DarkRed;
            this.button18.Margin = new Thickness(12, 48, 0, 0);
            this.button18.Name = "button17";
            this.button18.Height = 31;
            this.button18.Width = 50;
            this.button18.TabIndex = 18;
            this.button18.Content = "+/-";
            this.button18.Click += this.button18_Click;

            this.textBox1.Background = Brushes.DarkGray;
            this.textBox1.FontSize = 12f;
            this.textBox1.FontFamily = new FontFamily("Microsoft Sans Serif");
            this.textBox1.Foreground = Brushes.GhostWhite;
            this.textBox1.Margin = new Thickness(12, 12, 0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.IsReadOnly = true;
            this.textBox1.Width = 146;
            this.textBox1.Height = 16;
            this.textBox1.TabIndex = 16;
            this.textBox1.HorizontalContentAlignment = HorizontalAlignment.Right;

            //this.AutoScaleDimensions = new SizeF(6f, 13f);
            //this.AutoScaleMode = AutoScaleMode.Font;
            this.Height = 238;
            this.Width = 170;
            grid = new Grid();
            this.grid.Children.Add((Control)this.button18);
            this.grid.Children.Add((Control)this.button17);
            this.grid.Children.Add((Control)this.textBox1);
            this.grid.Children.Add((Control)this.button13);
            this.grid.Children.Add((Control)this.button14);
            this.grid.Children.Add((Control)this.button15);
            this.grid.Children.Add((Control)this.button16);
            this.grid.Children.Add((Control)this.button9);
            this.grid.Children.Add((Control)this.button10);
            this.grid.Children.Add((Control)this.button11);
            this.grid.Children.Add((Control)this.button12);
            this.grid.Children.Add((Control)this.button5);
            this.grid.Children.Add((Control)this.button6);
            this.grid.Children.Add((Control)this.button7);
            this.grid.Children.Add((Control)this.button8);
            this.grid.Children.Add((Control)this.button4);
            this.grid.Children.Add((Control)this.button3);
            this.grid.Children.Add((Control)this.button2);
            this.grid.Children.Add((Control)this.button1);
            this.ResizeMode = ResizeMode.CanResize;
            this.Name = nameof(MainWindow);
            this.Title = "Calc";
            this.Content = grid;
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
