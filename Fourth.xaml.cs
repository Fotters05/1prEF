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

namespace praktika1_EF
{
    /// <summary>
    /// Логика взаимодействия для Fourth.xaml
    /// </summary>
    public partial class Fourth : Page
    {
        private praktika1_datasetEntities Context = new praktika1_datasetEntities();

        public Fourth()
        {
            InitializeComponent();
            SushiDataGrid.ItemsSource = Context.INFOBARS.ToList();
        }
        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}
