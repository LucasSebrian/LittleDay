using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Browser;

namespace LittleDay.Services;

public interface IUsuarioService
{
    Task<LoginResult> LoginAsync();
    Task<LoginResult> LoginAsync(WebView webView);
    Task<BrowserResult> LogoutAsync();
}