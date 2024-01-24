using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class Command : ICommand
    {
        private readonly Action method;
        private readonly Func<bool>? ready;
        public event EventHandler? CanExecuteChanged;

        public Command(Action method, Func<bool>? ready = null)
        {
            if (method is null) throw new ArgumentNullException("method");

            this.method = method;
            this.ready = ready;
        }

        public bool CanExecute(object? parameter)
        {
            if (ready is null)
            {
                return false;
            }
            else
            {
                return ready();
            }
        }

        public void Execute(object? parameter)
        {
            method();
        }

        internal void NotifyCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        private bool DefaultAction()
        {
            return true;
        }

        private bool DefaultReady()
        {
            return false;
        }
    }
}
