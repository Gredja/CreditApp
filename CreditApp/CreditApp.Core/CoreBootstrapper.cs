using System;
using CreditApp.Core.ViewModels;
using CreditApp.Domain.Services.Services;
using CreditApp.Domain.Services.Services.Interfaces;
using CreditApp.Infrastructure.Data.Repositories;
using CreditApp.Infrastructure.Data.Repositories.Interfaces;
using Ninject;
using Ninject.Parameters;

namespace CreditApp.Core
{
    public abstract class CoreBootstrapper
    {
        private StandardKernel _kernel;

        public static CoreBootstrapper Instance { get; private set; }

        protected abstract void PlatformInitialize(StandardKernel kernel);

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

        public static bool TryInitialize(CoreBootstrapper instance)
        {
            if (Instance != null)
            {
                return false;
            }

            Instance = instance;

            Instance.Initialize();

            return true;
        }

        private void Initialize()
        {
            _kernel = new StandardKernel();

            PlatformInitialize(_kernel);

            _kernel.Bind<HomeViewModel>().ToSelf().InSingletonScope();
            _kernel.Bind<IDatabaseRepository>().To<DatabaseRepository>().InSingletonScope();
            _kernel.Bind<IDbService>().To<DbService>().InSingletonScope();
        }
    }
}
