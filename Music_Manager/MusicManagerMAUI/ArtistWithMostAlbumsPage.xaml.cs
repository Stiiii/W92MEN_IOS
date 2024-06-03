namespace MusicManagerMAUI;

public partial class ArtistWithMostAlbumsPage : ContentPage
{
	public ArtistWithMostAlbumsPage(ArtistWithMostAlbumsPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}