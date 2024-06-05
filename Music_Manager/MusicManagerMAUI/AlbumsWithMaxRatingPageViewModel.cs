using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MusicManagerMAUI;

public partial class AlbumsWithMaxRatingPageViewModel : ObservableObject
{
    RestService restService = new RestService("https://localhost:7254/", "Stat/AlbumsWithMaxRating");

    [ObservableProperty]
    ObservableCollection<Album> albums;

    [ObservableProperty]
    bool isBusy;

    public AlbumsWithMaxRatingPageViewModel()
    {
        albums = new ObservableCollection<Album>();
        GetAlbumsAsync();
    }

    async Task GetAlbumsAsync()
    {
        IsBusy = true;
        albums.Clear();
        var list = await restService.GetAsync<Album>("Stat/AlbumsWithMaxRating");
        list.ForEach(x => albums.Add(x));
        IsBusy = false;
    }
}