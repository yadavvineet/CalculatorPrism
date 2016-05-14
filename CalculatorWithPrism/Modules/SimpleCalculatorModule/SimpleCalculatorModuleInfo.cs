using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;
using SimpleCalculatorModule.Views;

namespace SimpleCalculatorModule
{
    public class SimpleCalculatorModuleInfo : IModule
    {
        private readonly IRegionManager _regionManager;

        #region Ctor

        public SimpleCalculatorModuleInfo(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion


        #region Overrides
        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainApplicationRegion", typeof (SimpleCalculator));
        }

        #endregion
    }
}