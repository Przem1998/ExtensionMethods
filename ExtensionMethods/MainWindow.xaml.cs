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

namespace ExtensionMethods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _Word = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TransformString_Click(object sender, RoutedEventArgs e)
        {

            _Word = inputWord.Text;
            if (_Word.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono napisu");
                afterTransform.Content = "Błąd!!!";
                afterTransform.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                afterTransform.Foreground = new SolidColorBrush(Colors.Black);
                if (UpperLowerString.IsChecked == true) afterTransform.Content = "Przekształcony napis: " + _Word.UpperEvenLetter();
                else if (UpperLetterFirst.IsChecked == true) afterTransform.Content = "Przekształcony napis: " + _Word.UpperFirstLetter();
            }
        }

    }
}
