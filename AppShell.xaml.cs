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
        }
    }
}
