using System;
using System.Collections.Generic;
using System.Text;

using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MVVMupdated.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
