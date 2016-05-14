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
    public class MainWindowViewModel : BindableBase
    {
        private string _statusString;

        public string StatusString
        {
            get { return _statusString; }
            set { SetProperty(ref _statusString, value); }
        }

        public MainWindowViewModel()
        {
            StatusString = $"Calulcator Version {GetVersionNumber()} (c) vineetyadav.com";
        }
        
        private string GetVersionNumber()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version = fvi.FileVersion;
            return version;
        }
    }
}
