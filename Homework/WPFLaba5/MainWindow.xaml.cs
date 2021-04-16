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

namespace WPFLaba5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[] arrayOfButtons = new Button[16];
        private Random random = new Random();
        private List<int> numbers = new List<int>();
        private int i = 1;
        private int randomValue;
        private TabControl tbControl;
        private TabItem tbItem1;
        private Button btnRemove;
        private Button btnAdd;
        private ComboBox comboBox1;
        private TabItem tbItem2;
        private TextBox txtBox;
        private TextBox txtBoxResult;
        private Button button1;
        Grid gridFortbItem2 = new Grid();

        public MainWindow()
        {
            InitializeComponent();
            this.Init();
            int num1 = 1;
            foreach (Button btn in this.arrayOfButtons)
                this.numbers.Add(num1++);
            int num2 = 0;
            int num3 = 0;
            for (int index1 = 1; index1 < this.arrayOfButtons.Length + 1; ++index1)
            {
                this.button1 = new Button();
                this.button1.Width = 30;
                this.button1.Height = 30;
                Button button1 = this.button1;
                int num4 = num3;
                var width = this.button1.Width;
                var x = num4 * width + 60;
                int num5 = (index1 - 1) % 4;
                var height = this.button1.Height;
                var y = num5 * height + 30;
                button1.Margin = new Thickness(x, y, 0, 0);
                int index2 = this.random.Next(this.numbers.Count - 1);
                var btnName = this.numbers[index2].ToString();
                this.button1.Name = SetButtonName(button1, btnName);
                this.button1.Width = 20;
                this.button1.Height = 20;
                SetRuleAligment(button1);
                this.button1.Visibility = Visibility.Visible;
                this.button1.Content = this.numbers[index2].ToString();
                this.button1.Click += this.btnArray_Click;
                this.numbers.RemoveAt(index2);
                num2 = index2 + 1;
                this.arrayOfButtons[index1 - 1] = this.button1;
                this.gridFortbItem2.Children.Add((Control)this.arrayOfButtons[index1 - 1]);
                if (index1 % 4 == 0)
                    ++num3;
            }
            this.tbItem2.Content = gridFortbItem2;
            mainGrid.Children.Add(tbControl);
            int num6 = 1;
            foreach (Button btn in this.arrayOfButtons)
                this.numbers.Add(num6++);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (GetButtonName(sender as Button)== this.btnAdd.Name)
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
            if (GetButtonName(sender as Button) == this.i.ToString())
            {
                this.txtBoxResult.Text = "";
                (sender as Button).Visibility = Visibility.Hidden;
                this.numbers.RemoveAt(this.numbers.IndexOf(this.i));
                foreach (Button btn in this.arrayOfButtons)
                {
                    if (btn.Visibility is Visibility.Visible)
                    {
                        this.randomValue = this.random.Next(this.numbers.Count);
                        Button button1 = btn;
                        int number = this.numbers[this.randomValue];
                        string str1 = number.ToString();
                        button1.Name = SetButtonName(button1, str1);
                        Button button2 = btn;
                        number = this.numbers[this.randomValue];
                        string str2 = number.ToString();
                        button2.Content = str2;
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
            MessageBox.Show("Красава, тобі вдалося!", "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);
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
                if (btn.Visibility != Visibility.Visible)
                    btn.Visibility = Visibility.Visible;
                this.randomValue = this.random.Next(this.numbers.Count - 1);
                Button button1 = btn;
                int number = this.numbers[this.randomValue];
                string str1 = number.ToString();
                button1.Name = SetButtonName(button1, str1);
                Button button2 = btn;
                number = this.numbers[this.randomValue];
                string str2 = number.ToString();
                button2.Content = str2;
                this.numbers.RemoveAt(this.randomValue);
            }
            for (int i = this.i; i < this.arrayOfButtons.Length + 1; ++i)
                this.numbers.Add(i);
        }

        private void Init()
        {
            this.txtBox = new TextBox();
            this.txtBox.Background = Brushes.Coral;
            this.txtBox.Margin = new Thickness(6, 9, 0, 0);
            this.txtBox.Name = "txtBox";
            this.txtBox.Width = 121;
            this.txtBox.Height = 20;
            this.txtBox.TabIndex = 3;


            this.btnRemove = new Button();
            this.btnRemove.Foreground = Brushes.Goldenrod;
            this.btnRemove.VerticalAlignment = VerticalAlignment.Top;
            this.btnRemove.HorizontalAlignment = HorizontalAlignment.Left;
            this.btnRemove.Margin = new Thickness(50, 6, 0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Width = 75;
            this.btnRemove.Height = 23;
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Content = "Видалити";
            this.btnRemove.Click += this.btn_Click;

            this.btnAdd = new Button();
            this.btnAdd.Foreground = Brushes.DarkSlateBlue;
            this.btnAdd.Margin = new Thickness(50, 6, 0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Width = 75;
            this.btnAdd.Height = 23;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Content = "Додати";
            this.btnAdd.Click += this.btn_Click;

            this.comboBox1 = new ComboBox();
            this.comboBox1.Background = Brushes.Chocolate;
            this.comboBox1.Margin = new Thickness(6, 43, 0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Width = 121;
            this.comboBox1.Height = 23;
            this.comboBox1.TabIndex = 0;

            this.txtBoxResult = new TextBox();
            this.txtBoxResult.Background = Brushes.LawnGreen;
            this.txtBoxResult.Margin = new Thickness(119, 174, 0, 0);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Width = 147;
            this.txtBoxResult.Height = 20;
            this.txtBoxResult.TabIndex = 0;

            this.button1 = new Button();
            this.button1.Margin = new Thickness(30, 23, 0, 0);
            this.button1.Name = "button1";
            this.button1.Width = 40;
            this.button1.Height = 20;
            this.button1.TabIndex = 1;
            this.button1.Background = Brushes.Red;
            this.button1.Content = "button1";

            this.tbItem1 = new TabItem();
            var gridFortbItem1 = new Grid();
            gridFortbItem1.Width = 150;
            gridFortbItem1.Height = 150;
            gridFortbItem1.Children.Add((Control)this.txtBox);
            gridFortbItem1.Children.Add((Control)this.btnRemove);
            gridFortbItem1.Children.Add((Control)this.btnAdd);
            gridFortbItem1.Children.Add((Control)this.comboBox1);
            this.tbItem1.Content = gridFortbItem1;
            this.tbItem1.Margin = new Thickness(4, 22, 0, 0);
            this.tbItem1.Name = "tbItem1";
            this.tbItem1.Padding = new Thickness(3);
            this.tbItem1.Width = 100;
            this.tbItem1.Height = 50;
            this.tbItem1.TabIndex = 0;
            this.tbItem1.Header = "Завдання 1";
            this.tbControl = new TabControl();
            this.tbControl.Items.Add(tbItem1);



            this.tbItem2 = new TabItem();
            var gridFortbItem2 = new Grid();
            gridFortbItem2.Width = 150;
            gridFortbItem2.Height = 150;
            gridFortbItem2.Children.Add((Control)this.txtBoxResult);
            this.tbItem2.Content = gridFortbItem2;
            this.tbItem2.Margin = new Thickness(4, 22, 0, 0);
            this.tbItem2.Name = "tbItem2";
            this.tbItem2.Padding = new Thickness(3);
            this.tbItem2.Width = 100; //372
            this.tbItem2.Height = 50;
            this.tbItem2.TabIndex = 1;
            this.tbItem2.Header = "Завдання 2";
            this.tbControl.Items.Add(tbItem2);

            this.tbControl.Margin = new Thickness(10, 10, 0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            SetRuleAligment(tbControl);
            this.tbControl.Width = 400;
            this.tbControl.Height = 400;
            this.tbControl.TabIndex = 0;
            this.Width = 900;
            this.Height = 700;
            this.Name = nameof(MainWindow);
            this.Title = nameof(MainWindow);
        }

        public string SetButtonName(Button button, string name)
        {
            button.Name = $"btn_{name}";
            return button.Name;
        }

        public string GetButtonName(Button button)
        {
            var name = button.Name.Split('_');
            if (name.Length >= 2)
                return name[1];
            return button.Name;
        }

        public void SetRuleAligment(Control control)
        {
            control.VerticalAlignment = VerticalAlignment.Top;
            control.HorizontalAlignment = HorizontalAlignment.Left;
        }
    }
}
