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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _rand = new Random();
        public int coontseven = 0;
        public int coont = 0;
        public MainWindow()
        {
            InitializeComponent();
            safd();
        }

        private void OutButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DoButton_Click(object sender, RoutedEventArgs e)
        {
            safd();
        }

        public string GenerateRandomNumber() 
        {
            int randomInt = _rand.Next(1, 10); 
            return randomInt.ToString();
        }
        public void safd()
        {
            coont++;
            string text1 = GenerateRandomNumber();
            first.Text = text1;

            string text2 = GenerateRandomNumber();
            second.Text = text2;

            string text3 = GenerateRandomNumber();
            third.Text = text3;

            if (text1 == "7" || text2 == "7" || text3 == "7")
            {
                ResultText.Visibility = Visibility.Visible;
                coontseven++;
                Photo.Visibility = Visibility.Visible;
            }
            else
            {
                ResultText.Visibility = Visibility.Collapsed;
                Photo.Visibility = Visibility.Collapsed;
            }
            double hf = (coontseven / (double)coont) * 100;
            procent.Text = hf.ToString();
        }
    }
    
}
