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
    /// Interaction logic for AutharizationWindow.xaml
    /// </summary>
    public partial class AutharizationWindow : Window
    {
        private readonly AuthDataStore authDataStore = new AuthDataStore(new AppData.ApplicationContext());
        public AutharizationWindow()
        {
            InitializeComponent();
        }


        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            PorductWindow porductWindow = new PorductWindow();
            string login = loginTextBox.Text;
            string passwod = passwordTextBox.Password;

            User user = authDataStore.Autharization(login, passwod);


            if(user != null)
            {
                switch (user.RoleId)
                {
                    case 1:
                        this.Close();
                        porductWindow.ShowDialog();
                        break;
                    case 2:
                        this.Close();
                        porductWindow.ShowDialog();
                        break;
                    case 3:
                        this.Close();
                        porductWindow.ShowDialog();
                        break;
                }
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
