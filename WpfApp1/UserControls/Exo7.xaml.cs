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
    /// Logique d'interaction pour Exo7.xaml
    /// </summary>
    public partial class Exo7 : UserControl
    {
        public Exo7()
        {
            InitializeComponent();

            ListBox list = new ListBox();

            list.Items.Add(new ListBoxItem
            {
                Content = "Item 1",
                IsEnabled =true,
                IsSelected = true
            });

            list.Items.Add(new ListBoxItem
            {
                Content = "Item 2",
                IsEnabled =true,
                IsSelected = false
            });

            list.Items.Add(new ListBoxItem
            {
                Content = "Item 3",
                IsEnabled =false,
                IsSelected = false
            });

            list.Items.Add("Item 4");



            listeCSharp.Children.Add(list);

        }
    }
}
