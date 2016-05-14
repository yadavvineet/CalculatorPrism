using System.Windows;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using SimpleCalculatorModule;

namespace CalculatorWithPrism
{
    public class CalculatorBootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// Creates the shell or main window of the application.
        /// </summary>
        /// <returns>
        /// The shell of the application.
        /// </returns>
        /// <remarks>
        /// If the returned instance is a <see cref="T:System.Windows.DependencyObject"/>, the
        ///             <see cref="T:Prism.Bootstrapper"/> will attach the default <see cref="T:Prism.Regions.IRegionManager"/> of
        ///             the application in its <see cref="F:Prism.Regions.RegionManager.RegionManagerProperty"/> attached property
        ///             in order to be able to add regions by using the <see cref="F:Prism.Regions.RegionManager.RegionNameProperty"/>
        ///             attached property from XAML.
        /// </remarks>
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Views.MainWindow>();
        }

        /// <summary>
        /// Initializes the shell.
        /// </summary>
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures the <see cref="T:Prism.Modularity.IModuleCatalog"/> used by Prism.
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            var moduleCatalog = (ModuleCatalog) ModuleCatalog;
            moduleCatalog.AddModule(typeof (SimpleCalculatorModuleInfo));
        }
    }
}
