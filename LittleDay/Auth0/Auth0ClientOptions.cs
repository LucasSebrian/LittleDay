namespace LittleDay.Auth0;

public class Auth0ClientOptions
{
    public Auth0ClientOptions()
    {
        Scope = "openid";
        RedirectUri = "myapp://callback";
        Browser = new WebBrowserAuthenticator();
    }

    public string Domain { get; set; } = string.Empty;

    public string ClientId { get; set; } = string.Empty;

    public string RedirectUri { get; set; }

    public string Scope { get; set; }
    public string Audience { get; set; }

    public IdentityModel.OidcClient.Browser.IBrowser Browser { get; set; }
}
