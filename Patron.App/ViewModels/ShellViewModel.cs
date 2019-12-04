using Patron.Infrastructure;
using Prism.Mvvm;
using Prism.Regions;

namespace Patron.App.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private string _title = "Patron";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ShellViewModel(IRegionManager regionManager)
        {
          //  regionManager.RequestNavigate("ContentRegion", RegionNames.Uchet);
        }
    }
}
