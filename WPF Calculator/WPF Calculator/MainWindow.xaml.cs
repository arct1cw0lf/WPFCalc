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

namespace WPF_Calculator
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


        //gets rid of preview text
        private void textBox1_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Second #" || txtBox.Text == "First #")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            double a1 = 0;
            double a2 = 0;
            bool p1 = double.TryParse(textBox.Text, out a1);
            bool p2 = double.TryParse(textBox1.Text, out a2);
            if (p1 && p2)
            {
                double a3 = a1 + a2;
                answer.Text = "= " + a3;
            }
            else
            {
                answer.Text = "= Error. Please only enter numbers";
            }
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            double s1 = 0;
            double s2 = 0;
            bool p3 = double.TryParse(textBox.Text, out s1);
            bool p4 = double.TryParse(textBox1.Text, out s2);
            if (p3 && p4)
            {
                double s3 = s1 - s2;

                answer.Text = "= " + s3;
            }
            else
            {
                answer.Text = "= Error. Please only enter numbers";
            }


        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            double m1 = 0;
            double m2 = 0;
            bool p5 = double.TryParse(textBox.Text, out m1);
            bool p6 = double.TryParse(textBox1.Text, out m2);

            if (p5 && p6)
            {
                double m3 = m1 * m2;
                answer.Text = "= " + m3;
            }
            else
            {
                answer.Text = "= Error. Please only enter numbers";
            }


        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            double d1 = 0;
            double d2 = 0;
            double d3 = 1;
            bool p7 = double.TryParse(textBox.Text, out d1);
            bool p8 = double.TryParse(textBox1.Text, out d2);

            if (p7 && p8)
            {



                //division by 0 protection
                if (d2 != 0)
                {
                    d3 = d1 / d2;
                    answer.Text = "= " + d3;
                }
                else
                {
                    d3 = 0;
                    answer.Text = "= Error, Division by 0";
                }

            }
            else
            {
                answer.Text = "= Error. Please only enter numbers";
            }






        }
    }
}

