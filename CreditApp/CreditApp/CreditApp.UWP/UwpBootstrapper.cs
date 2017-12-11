using CreditApp.Core;
using CreditApp.Infrastructure.Data;
using CreditApp.UWP.Services;
using Ninject;

namespace CreditApp.UWP
{
    public class UwpBootstrapper : CoreBootstrapper
    {
        protected override void PlatformInitialize(StandardKernel kernel)
        {
            kernel.Bind<ISqLiteConnection>().To<SqLiteConnection>().InSingletonScope();
        }
    }
}
