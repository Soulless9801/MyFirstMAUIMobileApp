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
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(LayoutStackPage), typeof(LayoutStackPage));
            Routing.RegisterRoute(nameof(LayoutVerticalStackPage), typeof(LayoutVerticalStackPage));
            Routing.RegisterRoute(nameof(LayoutHorizontalStackPage), typeof(LayoutHorizontalStackPage));
            Routing.RegisterRoute(nameof(LayoutAbsolutePage), typeof(LayoutAbsolutePage));
            Routing.RegisterRoute(nameof(LayoutFlexPage), typeof(LayoutFlexPage));
        }
    }
}
