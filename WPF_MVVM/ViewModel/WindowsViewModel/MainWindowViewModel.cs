using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM.Model;

namespace WPF_MVVM.ViewModel.WindowsViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        //properties
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; OnChanged(); }
        }
        //..


        //ctors
        public MainWindowViewModel()
        {
            Text = "Hello MVVM =)";
        }
        //..


        //commands
        public ICommand ClickCommand
        {
            get
            {
                return new RelayCommand(
                    obj => 
                    {
                        Text = "Clicked!";
                    });
            }
        }
        //..

    }
}
