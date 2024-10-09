using Foundation.WindowsGUI.Models;
using Foundation.WindowsGUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Foundation.WindowsGUI.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }
      
        private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoggingList.Items.Filter = FilterMethod;
        }
        private bool FilterMethod(object obj)
        {
            var logging = (Models.Logging)obj;

            ComboBoxItem typeItem = (ComboBoxItem)cbFilter.SelectedItem;
            string value = typeItem.Content.ToString();

            if (value.Equals("ALL"))
            {
                return true;
            }

            return logging.Company.Contains(value, StringComparison.OrdinalIgnoreCase);
        }
    }
}
