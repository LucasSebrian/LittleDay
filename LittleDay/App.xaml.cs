using LittleDay.ViewModels;
using LittleDay.Views;

namespace LittleDay
{
    public partial class App : Application
    {
        public App(LoginViewModel loginViewModel)
        {
            InitializeComponent();

            MainPage = new AppShell(loginViewModel);
        }

        protected override async void OnStart()
        {
            var expiration = Preferences.Default.Get("AccessTokenExpiration", "");

            if (!string.IsNullOrEmpty(expiration))
            {
                DateTime expirationDate = DateTime.Parse(expiration);

                if (expirationDate > DateTime.Now)
                {
                    await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
                }
            }

            base.OnStart();
        }

    }
}