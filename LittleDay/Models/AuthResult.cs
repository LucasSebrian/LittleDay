namespace LittleDay.Models
{
    public class AuthResult
    {
        public string Rule { get; set; } = string.Empty;
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime Expired { get; set; }
    }
}