using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MVVMupdated.Core.ViewModels;


namespace MVVMupdated.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
