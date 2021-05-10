using System.Windows.Controls;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Exo8.xaml
    /// </summary>
    public partial class Exo8 : UserControl
    {
        public Exo8()
        {
            InitializeComponent();

            ComboBox combo = new ComboBox();

            combo.Name = "Mycombo";
   
            combo.Items.Add(new ComboBoxItem
            {
                Content = "Item 1",
                IsEnabled = true,
                IsSelected = true
            });

            combo.Items.Add(new ComboBoxItem
            {
                Content = "Item 2",
                IsEnabled = true,
                IsSelected = false
            });

            combo.Items.Add(new ComboBoxItem
            {
                Content = "Item 3",
                IsEnabled = false,
                IsSelected = false
            });

            combo.Items.Add("Item 4");



            ComboCSharp.Children.Add(combo);





        }
    }
}
