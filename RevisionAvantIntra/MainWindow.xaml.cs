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
            InitializeComponent();
        }

        public void OnMenuAfficherInfoClick(object sender, RoutedEventArgs e)
        {
            // Ceci est un exemple de string interpolation.
            MessageBox.Show($"Ma tasse -couleur- peut contenir -mls- mls de -contenu-");
        }
    }
}