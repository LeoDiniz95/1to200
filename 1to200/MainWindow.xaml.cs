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

namespace _1to200
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtNumbers.Visibility = Visibility.Hidden;
        }

        public string getNumbers() {
            List<string> lNumbers = new List<string>();

            for(int i = 1; i<= 200;i++)
                lNumbers.Add(i % 3 == 0 && i%5 == 0? "Z" : 
                             (i%3 == 0 ? "X" :
                             (i%5 == 0 ? "Y" : i.ToString())
                            ));

            return string.Join("; ", lNumbers);
        }

        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            txtNumbers.IsEnabled = true;
            txtNumbers.Visibility = Visibility.Visible;
            btnAction.IsEnabled = false;

            txtNumbers.Text = string.Empty;
            txtNumbers.Text = getNumbers();

            txtNumbers.IsEnabled = false;
        }
    }
}
