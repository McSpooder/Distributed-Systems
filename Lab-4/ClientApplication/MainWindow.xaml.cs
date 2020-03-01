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

namespace ClientApplication
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
            string input = textBox1.Text.ToString();
            ServiceReference1.TranslationServiceClient ts = new ServiceReference1.TranslationServiceClient();
            ServiceReference1.CompositeType translation = ts.TranslateToPigLatin(input);
            textBox2.Text = translation.TranslationStr;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string input = textBox1.Text.ToString();
            ServiceReference1.TranslationServiceClient ts = new ServiceReference1.TranslationServiceClient();
            ServiceReference1.CompositeType translation = ts.TranslateToRussian(input);
            textBox2.Text = translation.TranslationStr;
        }
    }
}
