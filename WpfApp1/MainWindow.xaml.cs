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
using WpfApp1.UserControls;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ((ComboBox)sender).SelectedItem;
            var choix = ((ComboBoxItem)item).Name.ToString();

            switch (choix)
            {
                case "Exo1": MainContent.Content = new Exo1(); break;
                case "Exo2": MainContent.Content = new Exo2(); break;
                case "Exo3": MainContent.Content = new Exo3(); break;
                case "Exo4": MainContent.Content = new Exo4(); break;
                case "Exo5": MainContent.Content = new Exo5(); break;
                case "Exo6": MainContent.Content = new Exo6(); break;
                case "Exo7": MainContent.Content = new Exo7(); break;
                case "Exo8": MainContent.Content = new Exo8(); break;
                case "Exo9": MainContent.Content = new Exo9(); break;
                case "Exo10": MainContent.Content = new Exo10(); break;
                default: break;
            }
        }    }
}
