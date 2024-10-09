using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foundation.WindowsGUI.Models
{
    public class LoggingManager
    {
        public static ObservableCollection<Logging> DatabaseLogging = new ObservableCollection<Logging>() {
            new Logging() { Name = "Error", Company = "CMC" },
            new Logging() { Name = "Mistake", Company = "FPT" },
            new Logging() { Name = "Accident", Company = "VTI" },
            new Logging() { Name = "Bug", Company = "VMO" },
            new Logging() { Name = "Warning", Company = "Nash" }
    };

        public static ObservableCollection<Logging> GetLoggings()
        {
            return DatabaseLogging;
        }

        public static void DeleteLogging(Logging logging)
        {
            DatabaseLogging.Remove(logging);
        }
    }
}
