using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
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

            var view2 = containerProvider.Resolve<ViewA>();
            view2.Content = new TextBlock
            {
                Text = "Hello from View 2",
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Center
            };
            region.Add(view2);
            region.Activate(view2);

            region.Activate(view1);
            region.Deactivate(view1);

            region.Activate(view2);
            region.Remove(view2);

            region.Activate(view1);

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
