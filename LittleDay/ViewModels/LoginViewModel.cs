using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IdentityModel.OidcClient;
using LittleDay.Services;
using LittleDay.Views;

namespace LittleDay.ViewModels;


[ObservableObject]
public partial class LoginViewModel(IUsuarioService usuarioService)
{
    [ObservableProperty]
    private string username = Preferences.Default.Get("Username", "");

    [ObservableProperty]
    private string picture = Preferences.Default.Get("UserPicture", "");

    [ObservableProperty]
    private bool loginProcessing;

    public WebView WebViewInstance { get; set; }

    private readonly IUsuarioService usuarioService = usuarioService;

    [RelayCommand]
    public async Task LoginClicked()
    {
        LoginProcessing = true;
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");

        try
        {
            LoginResult authResponse = null;

#if WINDOWS
                authResponse = await usuarioService.LoginAsync(WebViewInstance);
#else
            authResponse = await usuarioService.LoginAsync();
#endif

            if (!authResponse.IsError) 
            {
                Preferences.Default.Set("AccessToken", authResponse.AccessToken);
                Preferences.Default.Set("RefreshToken", authResponse.RefreshToken);
                Preferences.Default.Set("AccessTokenExpiration", authResponse.AccessTokenExpiration.ToString());
                Preferences.Default.Set("Username", authResponse.User.Identity.Name);
                Preferences.Default.Set("UserPicture", authResponse.User?.Claims?.FirstOrDefault(c => c.Type == "picture")?.Value);
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");

                Username = authResponse.User.Identity.Name;
                Picture = authResponse.User?.Claims?.FirstOrDefault(c => c.Type == "picture")?.Value;
            }
            else
            {
                await Toast.Make($"Falha no login. Detalhe: {authResponse.ErrorDescription}").Show();
            }
        }
        catch (Exception ex)
        {
            await Toast.Make($"Falha no login. Detalhe: {ex.Message}").Show();
        }
        finally
        {
            LoginProcessing = false;
        }
    }

    [RelayCommand]
    public async Task LogoutClicked()
    {
        var logoutResult = await usuarioService.LogoutAsync();

        if (!logoutResult.IsError)
        {
            Preferences.Default.Clear();
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        else
        {
            await Toast.Make($"Falha no login. Detalhe: {logoutResult.ErrorDescription}").Show();
        }
    }
}