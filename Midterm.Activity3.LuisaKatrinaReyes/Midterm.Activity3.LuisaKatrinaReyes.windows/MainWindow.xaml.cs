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

namespace Midterm.Activity3.LuisaKatrinaReyes.windows
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int From = int.Parse(TextBox_From.Text);
            int To = int.Parse(TextBox_To.Text);

            int sum = 0;
            int sumEven = 0;
            int sumOdd = 0;
            int even = 0;
            int odd = 0;
            for (int x = From; x <= To; x++)
            {
                sum += x;
                if (x % 2 == 0)
                {
                    sumEven = sumEven + x;
                    lblEven.Content = (even++) + 1;
                    lblSumEven.Content = sumEven.ToString();
                }
                else
                {
                    sumOdd = sumOdd + x;
                    lblOdd.Content = (odd++) + 1;
                    lblSumOdd.Content = sumOdd.ToString();
                }
            }
            lblResult.Content = sum.ToString();
        }
    }
}
