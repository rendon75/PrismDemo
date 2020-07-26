using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _text = "Hello from ViewAViewModel";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public DelegateCommand ClickCommand { get; private set; }

        public ViewAViewModel()
        {
            ClickCommand = new DelegateCommand(Click, CanClick);
        }

        private bool CanClick()
        {
            return true;
        }

        private void Click()
        {
            Text = "You clicked me!";
        }
    }
}
