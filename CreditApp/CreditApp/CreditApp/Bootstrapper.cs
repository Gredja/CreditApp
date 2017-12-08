using System;
using CreditApp.Core.UWP.Services;
using CreditApp.Core.ViewModels;
using CreditApp.Infrastructure.Data;
using Ninject;
using Ninject.Parameters;

namespace CreditApp.Core.UWP
{
    public class Bootstrapper
    {
        private static Bootstrapper _instance;
        private readonly StandardKernel _kernel;

        Bootstrapper()
        {
            _kernel = new StandardKernel();

            _kernel.Bind<ISqLiteConnection>().To<SqLiteConnection>().InSingletonScope();
            _kernel.Bind<HomeViewModel>().ToSelf().InSingletonScope();
        }

        public static Bootstrapper Instance => _instance ?? (_instance = new Bootstrapper());

        public T Create<T>()
        {
            return _kernel.Get<T>();
        }

        public T Create<T>(string propertyName, object value)
        {
            return _kernel.Get<T>(new ConstructorArgument(propertyName, value));
        }

        public T Create<T>(string propertyName1, object value1, string propertyName2, object value2)
        {
            return _kernel.Get<T>(new ConstructorArgument(propertyName1, value1), new ConstructorArgument(propertyName2, value2));
        }

        public Lazy<T> LazyResolve<T>()
        {
            return new Lazy<T>(Create<T>);
        }

        public void Initialize()
        {
            //SingleInstance
            //  _kernel.Build().AppFolderToStringConverter>().As<IAppFolderToStringConverter>().InstancePerLifetimeScope();


            //_kernel.<SqLiteConnection>().As<ISqLiteConnection>().InstancePerLifetimeScope();
            //_kernel.<DatabaseRepository>().As<IDatabaseRepository>().SingleInstance();
            //_kernel.<DatabaseManager>().As<IDatabaseManager>().SingleInstance();



            //screen viewmodels


        }
    }
}
