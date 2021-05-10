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

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Exo10.xaml
    /// </summary>
    public partial class Exo10 : UserControl
    {
        public Exo10()
        {
            InitializeComponent();
            contenu.Text = "Contenu de droit";

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            contenu.Text = "L'"+((MenuItem)sender).Header.ToString()+" es activée";
        }
    }
}
