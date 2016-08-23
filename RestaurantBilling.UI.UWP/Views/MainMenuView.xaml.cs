using MvvmCross.WindowsUWP.Views;

namespace RestaurantBilling.UI.UWP.Views
{
    /// <summary>
    /// MvvmCross Mods:
	/// - Changed class to inherit from MvxWindowsPage instead of User Control.
	/// - This change must also be made in the xaml file, replace <UserControl... with <views:MvxWindowsPage
	/// </summary>
    public sealed partial class MainMenuView : MvxWindowsPage
    {
        public MainMenuView()
        {
            this.InitializeComponent();
        }
    }
}
