using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

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
            _regionMananger.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
