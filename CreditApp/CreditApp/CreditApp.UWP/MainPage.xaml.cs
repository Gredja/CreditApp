using CreditApp.Core;

namespace CreditApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            CoreBootstrapper.TryInitialize(new UwpBootstrapper());

            LoadApplication(new Core.UWP.App());
        }
    }
}
