using CommunityToolkit.Mvvm.ComponentModel;

namespace MusicManagerMAUI;

public partial class ArtistWithMostAlbumsPageViewModel : ObservableObject
{
    RestService restService = new RestService("https://localhost:7254/", "Stat/ArtistWithMostAlbums");

    [ObservableProperty]
    Artist artistWithMostAlbums;

    public ArtistWithMostAlbumsPageViewModel()
    {
        artistWithMostAlbums = restService.GetSingle<Artist>("Stat/ArtistWithMostAlbums");

    }
}