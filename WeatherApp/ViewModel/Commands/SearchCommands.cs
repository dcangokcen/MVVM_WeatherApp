using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherApp.ViewModel.Commands
{
    public class SearchCommands : ICommand
    {
        public WeatherVM VM{ get; set; }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SearchCommands(WeatherVM vm)
        {
            VM = vm;
        }
        public bool CanExecute(object parameter)
        {
            string query = (string)parameter;
            if(string.IsNullOrEmpty(query)) 
                return false;
            return true;
        }

        public void Execute(object parameter)
        {
            VM.MakeQuery();
        }
    }
}
