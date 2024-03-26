using LittleDay.ViewModels;
using Xamarin.Forms;

namespace LittleDay.Views
{
    public partial class HomePage : ContentPage
    {

        private readonly HomeViewModel homeViewModel;

        public HomePage(HomeViewModel homeViewModel)
        {
            InitializeComponent();

            CollectionView.ItemsSource = homeViewModel.Histories;
            BindingContext = homeViewModel;

            this.homeViewModel = homeViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await homeViewModel.LoadHistories();
        }
    }
}