using System.Windows;

namespace Tableware.Windows
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        
        public StartWindow()
        {
            InitializeComponent();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
            this.Show();
        }

        private void AutharizationBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var authWindow = new AutharizationWindow();
            authWindow.ShowDialog();
            this.Show();
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var porductWindow = new PorductWindow();
            porductWindow.ShowDialog();
            this.Show();
        }
    }
}
