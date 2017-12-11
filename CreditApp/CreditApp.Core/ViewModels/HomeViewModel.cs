using CreditApp.Core.ViewModels.Base;
using CreditApp.Domain.Services.Services.Interfaces;

namespace CreditApp.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private string _name;
        private IDbService _dbService;

        public HomeViewModel(IDbService dbService)
        {
            _dbService = dbService;

            _dbService.ConfigureDb();


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
