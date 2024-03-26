using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LittleDay.Views;

namespace LittleDay.ViewModels
{
    [ObservableObject]
    public partial class SearchResultViewModel
    {
        [ObservableProperty]
        private string response;

        [ObservableProperty]
        private string image;

        [ObservableProperty]
        private string introTitle;

        private readonly HomeViewModel homeViewModel;

        public SearchResultViewModel(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
            Response = homeViewModel.WeatherForecast.Discriminicao;
            Image = homeViewModel.WeatherForecast.Image;
            IntroTitle = homeViewModel.WeatherForecast.IntroTitle;
        }

        [RelayCommand]
        public async Task NewSearch()
        {
            await homeViewModel.NewWeatherForecast();
        }

        [RelayCommand]
        public async Task BackHome()
        {
            await Shell.Current.GoToAsync("//"+ nameof(HomePage));
        }
    }
}