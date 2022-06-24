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
using Tableware.AppData;

namespace Tableware.Windows
{
    /// <summary>
    /// Interaction logic for PorductWindow.xaml
    /// </summary>
    public partial class PorductWindow : Window
    {
        public PorductWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            productList.ItemsSource = db.Product.ToList();
        }
    }
}
