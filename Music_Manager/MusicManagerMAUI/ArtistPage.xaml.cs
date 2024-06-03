namespace MusicManagerMAUI;

public partial class ArtistPage : ContentPage
{
	public ArtistPage(ArtistPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}