namespace WPF_MVVM.ViewModel
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnChanged([CallerMemberName]string propname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
    }
}
