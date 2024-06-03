namespace MusicManagerMAUI;

public partial class RatingPage : ContentPage
{
	public RatingPage(RatingPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}