using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding;
using MvvmCross.Binding.BindingContext;
using MVVMupdated.Core.ViewModels;

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

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(_tv).For(v => v.TextColors).To(vm => vm.Color).WithConversion("NativeColor");
            set.Apply();
        }
    }
}
