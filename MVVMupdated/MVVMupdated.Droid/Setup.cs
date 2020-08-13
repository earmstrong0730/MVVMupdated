using Android.Content;
using MvvmCross.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace MVVMupdated.Droid
{
    public class Setup : MvxAppCompatSetup
    {
        //public Setup(Context applicationContext) : base(applicationContext)
        //{
        //}

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
