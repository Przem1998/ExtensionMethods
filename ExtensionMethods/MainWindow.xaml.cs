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
                else if (UpperLetterFirst.IsChecked == true) afterTransform.Content = "Przekształcony napis: " + _Word.UpperFirstLetter();
                else if (DeleteVowels.IsChecked == true) afterTransform.Content = "Przekształcony napis: " + _Word.DeleteVowels();
                else if (AmountOfWordsInString.IsChecked == true) afterTransform.Content = "Ilość wyrazów w napisie: " + _Word.CountWordsInString();
                else if (CountLengthOfWords.IsChecked == true)
                {
                    string temp = "";
                    foreach(int i in _Word.LengthInscriptions())
                    {
                       temp+= "Długości napisów "+Convert.ToString(i);
                    }
                    afterTransform.Content = temp;
                }

                else if (CheckSentence.IsChecked == true) afterTransform.Content = _Word.IsSentence() == true ? "Wprowadzony napis jest zdaniem" : "Wprowadzony napis nie jest zdaniem";



            }
        }

    }
}
