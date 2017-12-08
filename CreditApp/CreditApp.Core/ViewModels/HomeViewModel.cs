using CreditApp.Core.ViewModels.Base;

namespace CreditApp.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private string _name;


        public HomeViewModel()
        {
            // _databaseManager = databaseManager;


            Name = "AlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlex";
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
