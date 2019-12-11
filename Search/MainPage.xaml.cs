using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Search
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> _data;

        public MainPage()
        {
            InitializeComponent();

            _data = new ObservableCollection<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            _list.ItemsSource = _data;

            _list.ItemSelected += Handle_list_ItemSelected;
        }

        private async void Handle_list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage());
        }
    }
}
