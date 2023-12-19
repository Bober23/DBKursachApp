using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace DBKursachApp
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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+"); 
            e.Handled = regex.IsMatch(e.Text);
        }
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int tch = 0;
            int n = 0;
            double u= 0;
            double fi = 0;
            double T1 = 0;
            try
            {
                if (tchBox.Text != null)
                {
                    tch = Convert.ToInt32(tchBox.Text);
                }
                if (nBox.Text != null)
                {
                    n = Convert.ToInt32(nBox.Text);
                }
                string material = materialBox.Text;
                string type = typeBox.Text;
                if (uBox.Text != null)
                {
                    u = Convert.ToDouble(uBox.Text);
                }
                if (fiBox.Text != null)
                {
                    fi = Convert.ToDouble(fiBox.Text);
                }
                if (t1Box != null)
                {
                    T1 = Convert.ToDouble(t1Box.Text);
                }
                if (material != null && type != null)
                {
                    ansD.Content = Calculator.CalculateD(tch, n, material, type, u, fi, T1);
                }
                else ansD.Content = "Введите все данные";
            }
            catch
            {
                ansD.Content = "Введите все данные корректно";
            }
        }
    }
}
