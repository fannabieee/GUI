using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Foundation.WindowsGUI.Models;
using Foundation.WindowsGUI.Commands;

namespace Foundation.WindowsGUI.ViewModel
{
    public class MainViewModel
    {
        public string? Name { get; set; }
        public string? Company { get; set; }
        public bool IsSelected { get; set; }
        public ICommand DeleteLoggingCommand { get; set; }
        public ObservableCollection<Logging> Loggings { get; set; }

        public MainViewModel()
        {
            Loggings = LoggingManager.GetLoggings();

            DeleteLoggingCommand = new RelayCommand(DeleteLogging, CanDeleteLogging);
        }

        private void DeleteLogging(object obj)
        {
            List<Logging> logsToDelete = Loggings.Where(log => log.IsSelected).ToList();

            foreach (Logging log in logsToDelete)
            {
                LoggingManager.DeleteLogging(log); 
            }
        }

        private bool CanDeleteLogging(object obj)
        {
            return true;
        }
    }
}
