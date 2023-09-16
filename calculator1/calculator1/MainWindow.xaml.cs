using System;
using System.Collections.Generic;
using System.Data;
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

namespace calculator1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        data dt = new data();
        string Caltotal;
        int num1;
        int num2;
        string option;
        int result;


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text += "0";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "";
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            option = "/";
            num1 = int.Parse(txt1.Text);
            txt1.Text = "";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            option = "-";
            num1 = int.Parse(txt1.Text);
            txt1.Text = "";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            option = "+";
            num1 = int.Parse(txt1.Text);
            txt1.Text = "";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            option = "*";
            num1 = int.Parse(txt1.Text);
            txt1.Text = "";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            num2 = int.Parse(txt1.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            if (option.Equals("-"))
            {
                result = num1 - num2;
            }
            if (option.Equals("/"))
            {
                result = num1 / num2;
            } 
            if (option.Equals("*"))
            {
                result = num1 * num2;
            }
            txt1.Text = result + "";
            try
            {
                /* num2 = int.Parse(txt1.Text);

                 if (option.Equals("+"))
                 {
                     result = num1 + num2;
                 }
                 if (option.Equals("-"))
                 {
                     result = num1 - num2;
                 }
                 if (option.Equals("/"))
                 {
                     result = num1 / num2;
                 }
                 if (option.Equals("*"))
                 {
                     result = num1 * num2;
                 }
                 txt1.Text = result + "";*/
                dt.InsertData(num1, option, num2, result);
                MessageBox.Show("data is stored");
                
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
           
        }

        private void display_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable table = dt.Select();
                datagrid.ItemsSource = table.DefaultView;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
