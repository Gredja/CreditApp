
namespace CreditApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new Core.UWP.App());
        }
    }
}
