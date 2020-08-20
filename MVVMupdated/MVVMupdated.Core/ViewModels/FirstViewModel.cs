using System;
using System.Collections.Generic;
using System.Text;

using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Drawing;

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

        private Color _color = Color.Red; //using system.drawing.color rather than Mvx Color
        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                RaisePropertyChanged(() => Color);
            }

        }           

    }
}
