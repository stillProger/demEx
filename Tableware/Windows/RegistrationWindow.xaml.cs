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
using System.Windows.Shapes;
using Tableware.Models;
using Tableware.Services;

namespace Tableware.Windows
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private readonly AuthDataStore authDataStore = new AuthDataStore(new AppData.ApplicationContext());
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            PorductWindow porductWindow = new PorductWindow();
            string login = loginTextBox.Text;
            string password = passwordTextBox.Password;
            string surname = surnameTextBox.Text;
            string name = nameTextBox.Text;
            string patronymic = patronymicTextBox.Text;

            User newUser = authDataStore.Registrstation(login, password, surname, name, patronymic);

            if(newUser != null)
            {
                this.Close();
                porductWindow.ShowDialog();
            }
        }
    }
}
