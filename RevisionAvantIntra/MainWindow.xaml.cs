using System.Windows;

namespace RevisionAvantIntra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }

        public void OnMenuAfficherInfoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Age: \n" +
                            $"Sexe: \n" +
                            $"Ville: ");
        }
    }
}