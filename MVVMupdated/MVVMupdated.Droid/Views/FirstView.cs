using Android.App;
using Android.OS;
using Android.Widget;

namespace MVVMupdated.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : BaseView
    {
        private TextView _tv;   // TextView widget reference

        protected override int LayoutResource => Resource.Layout.FirstView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);

            _tv = FindViewById<TextView>(Resource.Id.textView1);

            _tv.SetTextColor(Android.Graphics.Color.Red);
        }
    }
}
