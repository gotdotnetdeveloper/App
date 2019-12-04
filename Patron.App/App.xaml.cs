using Patron.App.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using CommonServiceLocator;
using DryIoc;
using Patron.Admin;
using Patron.Uchet;
using Prism.DryIoc;

namespace Patron.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
      

        //protected override Rules CreateContainerRules() 
        //    => Rules.Default.WithAutoConcreteTypeResolution()
        //    .With(Made.Of(FactoryMethod.ConstructorWithResolvableArguments))
        //    .WithDefaultIfAlreadyRegistered(IfAlreadyRegistered.Replace);

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // todo: RegisterTypes
        }

        /// <summary>
        /// Конфигурация каталога.
        /// </summary>
        /// <param name="moduleCatalog"></param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(typeof(AdminModule));
            moduleCatalog.AddModule(typeof(UchetModule));
        }

        /// <summary>
        /// Создание оболочки.
        /// </summary>
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();

        }
    }
}
