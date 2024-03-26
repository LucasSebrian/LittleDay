using LittleDay.ViewModels;
using LittleDay.Views;

namespace LittleDay
{
    public partial class AppShell : Shell
    {
        public AppShell(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            BindingContext = loginViewModel;

            Routing.RegisterRoute(nameof(SearchResult), typeof(SearchResult));
        }
    }
}
