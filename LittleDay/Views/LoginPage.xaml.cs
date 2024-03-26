using LittleDay.Auth0;
using LittleDay.ViewModels;

namespace LittleDay.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		BindingContext = loginViewModel;
        loginViewModel.WebViewInstance = WebViewInstance;
	}
}