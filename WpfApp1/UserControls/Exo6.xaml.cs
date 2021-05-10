using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Exo6.xaml
    /// </summary>
    public partial class Exo6 : UserControl
    {
        public Exo6()
        {
            InitializeComponent();

            TextBlock hello = new TextBlock();
            Button buttonWorld = new Button();

            Thickness margin = new Thickness(10,10,0,0);

            hello.Text = "Hello";
            hello.Margin = margin;
    



            buttonWorld.Content = "world";
            buttonWorld.Margin = margin;
            buttonWorld.Click += Button_Click;
          

            HelloW.Orientation = Orientation.Horizontal;
            HelloW.Children.Add(hello);
            HelloW.Children.Add(buttonWorld);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("World");
        }


    }
}
