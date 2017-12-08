using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace CreditApp.Core.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;

        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (value != _isBusy)
                {
                    _isBusy = value;
                    OnPropertyChanged(nameof(IsBusy));
                }
            }
        }

        public virtual void OnAppearing() { }

        public virtual void OnDidAppear() { }

        public virtual void OnDisappearing() { }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
