using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;

namespace CalculatorWithPrism.ViewModels
{
    /// <summary>
    /// Class MainWindowViewModel.
    /// </summary>
    /// <seealso cref="Microsoft.Practices.Prism.Mvvm.BindableBase" />
    public class MainWindowViewModel : BindableBase
    {
        #region Fields

        /// <summary>
        /// The _status string
        /// </summary>
        private string _statusString;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the status string.
        /// </summary>
        /// <value>The status string.</value>
        public string StatusString
        {
            get { return _statusString; }
            set { SetProperty(ref _statusString, value); }
        }
        #endregion


        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            StatusString = $"Calulcator Version {GetVersionNumber()} (c) vineetyadav.com";
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Gets the version number.
        /// </summary>
        /// <returns>System.String.</returns>
        private string GetVersionNumber()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version = fvi.FileVersion;
            return version;
        }
        #endregion
    }
}
