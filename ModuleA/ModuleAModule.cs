using ModuleA.ViewModels;
using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private IRegionManager _regionMananger;

        public ModuleAModule(IRegionManager regionManager)
        {
            _regionMananger = regionManager;    
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegion region = _regionMananger.Regions["ContentRegion"];

            var view1 = containerProvider.Resolve<ViewA>();
            region.Add(view1);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // ViewModelLocationProvider.Register<ViewA, ViewAViewModel>();

            //ViewModelLocationProvider.Register<ViewA>(() =>
            //{
            //    return new ViewAViewModel() { Text = "Hello from factory." };
            //});
        }
    }
}
