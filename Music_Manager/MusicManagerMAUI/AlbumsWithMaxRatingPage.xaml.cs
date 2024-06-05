namespace MusicManagerMAUI;

public partial class AlbumsWithMaxRatingPage : ContentPage
{
	public AlbumsWithMaxRatingPage(AlbumsWithMaxRatingPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}