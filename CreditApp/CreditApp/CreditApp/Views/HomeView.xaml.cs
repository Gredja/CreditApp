using CreditApp.Core.ViewModels;
using Ninject;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditApp.Core.UWP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            BindingContext = Bootstrapper.Instance.Create<HomeViewModel>();
        }
    }
}