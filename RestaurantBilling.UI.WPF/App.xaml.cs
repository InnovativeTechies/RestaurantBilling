using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Windows;

namespace RestaurantBilling.UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Flag to determine whether setup has been performed already.
        bool _setupComplete;

        protected override void OnActivated(EventArgs e)
        {
            if(!_setupComplete) DoSetup();
            base.OnActivated(e);
        }

        void DoSetup()
        {
            var presenter = new CustomViewPresenter(MainWindow);

            var setup = new Setup(Dispatcher, presenter);
            setup.Initialize();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            _setupComplete = true;
        }
    }
}
