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

namespace _185301NumberMath
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables
        int x;
        int y;
        int answer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddInt_Click(object sender, RoutedEventArgs e)
        {
            setXandY();
            answer = x + y;
            lblOutput.Content = answer.ToString();
        }

        private void setXandY()
        {
            int.TryParse(txtX.Text, out x);
            int.TryParse(txtY.Text, out y);
        }

        private void btnSubtractInt_Click(object sender, RoutedEventArgs e)
        {


            setXandY();
            answer = x - y;
            lblOutput.Content = answer.ToString();
        }

        private void btnMultiplyInt_Click(object sender, RoutedEventArgs e)
        {


            setXandY();
            answer = x * y;
            lblOutput.Content = answer.ToString();
        }

        private void btnDivideInt_Click(object sender, RoutedEventArgs e)
        {


            setXandY();
            answer = x / y;
            lblOutput.Content = answer.ToString();
        }

        private void btnModulusInt_Click(object sender, RoutedEventArgs e)
        {
            setXandY();
            answer = x % y;
            lblOutput.Content = answer.ToString();
        }
    }
}
