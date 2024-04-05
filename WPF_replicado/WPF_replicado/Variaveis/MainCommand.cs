using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_replicado.Variaveis 
{
  public class MainCommand : ICommand
    { 
        public MainView mainView { get; set; }

        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainView.Finalizar();
        }

    }
}