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

namespace CashRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double temp = 0;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "1";
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "2";
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "3";
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "4";
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "5";
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "6";
        }

        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "7";
        }

        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "8";
        }

        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "9";
        }

        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Text = InputTxtBox.Text + "0";
        }

        private void Dec_Click(object sender, RoutedEventArgs e)
        {
            if (InputTxtBox.Text.Contains("."))
            {

            }
            else
            {
                InputTxtBox.Text = InputTxtBox.Text + ".";
            }
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            temp = Convert.ToDouble(InputTxtBox.Text) + temp;
            InputTxtBox.Clear();
        }

        private void TotalBtn_Click(object sender, RoutedEventArgs e)
        {
            SubtotalTxtBox.Text = Convert.ToString(Math.Round((temp), 2));
            TaxTxtBox.Text = Convert.ToString(Math.Round((temp * .07),2));
            TotalTxtBox.Text = Convert.ToString(Math.Round((temp * .07) + temp, 2));

        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            InputTxtBox.Clear();
        }

        private void ClrBtn_Click(object sender, RoutedEventArgs e)
        {
            SubtotalTxtBox.Clear();
            TaxTxtBox.Clear();
            TotalTxtBox.Clear();
            temp = 0;

        }
    }
}
