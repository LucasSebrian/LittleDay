using LittleDay.ViewModels;

namespace LittleDay.Views;

public partial class SearchResult : ContentPage
{
    public SearchResult(SearchResultViewModel searchResultViewModel)
	{
		InitializeComponent();
        BindingContext = searchResultViewModel;
    }
}