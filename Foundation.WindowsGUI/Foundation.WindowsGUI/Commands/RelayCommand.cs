using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Foundation.WindowsGUI.Commands
{
    public class RelayCommand : ICommand
    {
        private ICommand? deleteLogging;
        private Func<object, bool> canDeleteLogging;

        public event EventHandler? CanExecuteChanged;
        private Action<object> _Excute { get; set; }
        private Predicate<object> _CanExcute { get; set; }

        public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {

            _Excute = ExcuteMethod;
            _CanExcute = CanExcuteMethod;
        }

        public RelayCommand(ICommand? deleteLogging, Func<object, bool> canDeleteLogging)
        {
            this.deleteLogging = deleteLogging;
            this.canDeleteLogging = canDeleteLogging;
        }

        public bool CanExecute(object? parameter)
        {
            return _CanExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Excute(parameter);
        }
    }
}
