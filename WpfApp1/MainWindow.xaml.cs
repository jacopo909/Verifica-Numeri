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
using Libreria2;

namespace WpfApp1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btVERIFICA_Click(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txtInserisci.Text);
            int n1 = (int)n;
            lbLabel1.Content = n1.ToString();
        }

        private void btARROTONDA_Click(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txtInserisci.Text);
            int n1 = (int)(n + 0.5);
            lbLabel2.Content = n1.ToString();
        }

        private void btPARI_DISPARI_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txtInserisci.Text);
            if (n1 % 2 == 0)
            {
                lbLabel3.Content = n1.ToString();
            }
            else
            {
                lbLabel3.Content = n1.ToString();
            }
        }
    }
}
