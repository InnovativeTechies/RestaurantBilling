using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views;
using RestaurantBilling.Core;
using System.Windows.Threading;

namespace RestaurantBilling.UI.WPF
{
    public class Setup : MvxWpfSetup
    {
        public Setup(Dispatcher uiThreadDispatcher, IMvxWpfViewPresenter presenter) : base(uiThreadDispatcher, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var dbConn = FileAccessHelper.GetLocalFilePath("restaurant.db3");
            Mvx.RegisterSingleton(new Repository(dbConn));
            return new Core.App();
        }
    }
}
