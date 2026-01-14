using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            // Layouts
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(LayoutStackPage), typeof(LayoutStackPage));
            Routing.RegisterRoute(nameof(LayoutVerticalStackPage), typeof(LayoutVerticalStackPage));
            Routing.RegisterRoute(nameof(LayoutHorizontalStackPage), typeof(LayoutHorizontalStackPage));
            Routing.RegisterRoute(nameof(LayoutAbsolutePage), typeof(LayoutAbsolutePage));
            Routing.RegisterRoute(nameof(LayoutFlexPage), typeof(LayoutFlexPage));

            //Images
            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));
            Routing.RegisterRoute(nameof(ImagesEmbeddedPage), typeof(ImagesEmbeddedPage));
            Routing.RegisterRoute(nameof(ImagesActivityIndicatorPage), typeof(ImagesActivityIndicatorPage));

            //Collections
            Routing.RegisterRoute(nameof(CollectionsPage), typeof(CollectionsPage));
            Routing.RegisterRoute(nameof(CollectionPage), typeof(CollectionPage));
            Routing.RegisterRoute(nameof(CollectionImagesPage), typeof(CollectionImagesPage));
            Routing.RegisterRoute(nameof(CollectionButtonsPage), typeof(CollectionButtonsPage));
            Routing.RegisterRoute(nameof(CollectionIconsPage), typeof(CollectionIconsPage));
            Routing.RegisterRoute(nameof(CollectionAddPage), typeof(CollectionAddPage));
            Routing.RegisterRoute(nameof(CollectionEditPage), typeof(CollectionEditPage));

            //Controls
            Routing.RegisterRoute(nameof(ControlsPage), typeof(ControlsPage));

            Routing.RegisterRoute(nameof(ControlSlidersPage), typeof(ControlSlidersPage));
            Routing.RegisterRoute(nameof(ControlSliderXAMLPage), typeof(ControlSliderXAMLPage));
            Routing.RegisterRoute(nameof(ControlSliderVMPage), typeof(ControlSliderVMPage));

            Routing.RegisterRoute(nameof(ControlSteppersPage), typeof(ControlSteppersPage));
            Routing.RegisterRoute(nameof(ControlStepperXAMLPage), typeof(ControlStepperXAMLPage));
            Routing.RegisterRoute(nameof(ControlStepperVMPage), typeof(ControlStepperVMPage));

            Routing.RegisterRoute(nameof(ControlSwitchesPage), typeof(ControlSwitchesPage));
            Routing.RegisterRoute(nameof(ControlSwitchXAMLPage), typeof(ControlSwitchXAMLPage));
            Routing.RegisterRoute(nameof(ControlSwitchVMPage), typeof(ControlSwitchVMPage));

            Routing.RegisterRoute(nameof(ControlEntriesPage), typeof(ControlEntriesPage));
            Routing.RegisterRoute(nameof(ControlEntryXAMLPage), typeof(ControlEntryXAMLPage));
            Routing.RegisterRoute(nameof(ControlEntryVMPage), typeof(ControlEntryVMPage));
            Routing.RegisterRoute(nameof(ControlEntryResultPage), typeof(ControlEntryResultPage));
        }
    }
}
