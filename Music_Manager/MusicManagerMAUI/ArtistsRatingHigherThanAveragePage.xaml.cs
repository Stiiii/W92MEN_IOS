namespace MusicManagerMAUI;

public partial class ArtistsRatingHigherThanAveragePage : ContentPage
{
	public ArtistsRatingHigherThanAveragePage(ArtistsRatingHigherThanAveragePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}