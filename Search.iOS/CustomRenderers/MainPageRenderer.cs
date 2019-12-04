using Search;
using Search.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]
namespace Search.iOS.CustomRenderers
{
    public class MainPageRenderer : Xamarin.Forms.Platform.iOS.PageRenderer, IUISearchControllerDelegate
    {
        private UISearchController _searchController;

        public override void WillMoveToParentViewController(UIViewController parent)
        {
            base.WillMoveToParentViewController(parent);
            SetSearchController(parent);
        }

        void SetSearchController(UIViewController parent)
        {
            _searchController = new UISearchController(searchResultsController: null);

            _searchController.HidesNavigationBarDuringPresentation = false;
            _searchController.DimsBackgroundDuringPresentation = false;
            _searchController.SearchBar.SearchBarStyle = UISearchBarStyle.Minimal;
            _searchController.AutomaticallyAdjustsScrollViewInsets = false;
            _searchController.Delegate = this;

            parent.NavigationItem.HidesSearchBarWhenScrolling = false;
            parent.NavigationItem.SearchController = _searchController;
        }
    }
}
