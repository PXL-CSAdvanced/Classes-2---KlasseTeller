using CS_Oefening;
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

namespace Classes_2___KlasseTeller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Counter _counterObj = new Counter();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_counterObj.CounterValue.ToString());
            // Of korter indien de Counter class een ToString() method heeft
            //MessageBox.Show(_counterObj.ToString());
        }

        private void increaseButton_Click(object sender, RoutedEventArgs e)
        {
            _counterObj.IncreaseCounter();
        }

        private void decreaseButton_Click(object sender, RoutedEventArgs e)
        {
            _counterObj.DecreaseCounter();
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            _counterObj.ResetCounter();
        }

        private void valueButton_Click(object sender, RoutedEventArgs e)
        {
            int value; 
            bool isSucceeded = int.TryParse(valueTextBox.Text, out value);
            if (!isSucceeded)
            {
                MessageBox.Show("Geef een geheel getal in!",
                    "Fout",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                valueTextBox.Text = "0";
            }
            else
            {
                _counterObj.Value(value);
            }
        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
