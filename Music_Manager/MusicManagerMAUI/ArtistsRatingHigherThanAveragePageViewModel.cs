using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MusicManagerMAUI;

public partial class ArtistsRatingHigherThanAveragePageViewModel : ObservableObject
{
    RestService restService = new RestService("https://localhost:7254/", "Stat/ArtistsRatingHigherThanAverage");

    [ObservableProperty]
    ObservableCollection<Artist> artists;

    [ObservableProperty]
    bool isBusy;

    public ArtistsRatingHigherThanAveragePageViewModel()
    {
        artists = new ObservableCollection<Artist>();
        GetArtistAsync();
    }

    async Task GetArtistAsync()
    {
        IsBusy = true;
        artists.Clear();
        var list = await restService.GetAsync<Artist>("Stat/ArtistsRatingHigherThanAverage");
        list.ForEach(x => artists.Add(x));
        IsBusy = false;
    }
}