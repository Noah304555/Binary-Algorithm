/* Noah Irving
5/27/2019
A program that converts numbers to binary
*/
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

namespace _304555Binary_Algorithm
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

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            double inputValue = 0;
            double.TryParse(input, out inputValue);
            string output = "";

            for (int i = 4; i >= 0; i--)
            {
                double temp = Math.Pow(2, i);
                if (inputValue >= temp)
                {
                    inputValue -= temp;
                    output = output + "1";

                }
                else
                {
                    output = output + "0";
                }

            }
            MessageBox.Show(output);
        }
    }
}
