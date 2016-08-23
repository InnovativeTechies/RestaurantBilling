using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace RestaurantBilling.UI.Droid.Views
{
    [Activity(Label = "View Bills", NoHistory = true)]
    public class AllBillsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_AllBills);
        }
    }
}