using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MusicManagerMAUI;

public partial class ArtistPageViewModel : ObservableObject
{
    RestService restService = new RestService("https://localhost:7254/", "Artist");

    [ObservableProperty]
    ObservableCollection<Artist> artists;

    [ObservableProperty]
    Artist selectedArtist;

    [ObservableProperty]
    Artist createArtist;

    [ObservableProperty]
    bool isBusy;

    public ArtistPageViewModel()
    {
        artists = new ObservableCollection<Artist>();
        createArtist = new Artist();
        GetArtistAsync();
    }

    async Task GetArtistAsync()
    {
        IsBusy = true;
        artists.Clear();
        var list = await restService.GetAsync<Artist>("artist");
        list.ForEach(x => artists.Add(x));
        IsBusy = false;
    }

    [RelayCommand]
    async Task CreateArtistAsync()
    {
        await restService.PostAsync<Artist>(new Artist() { ArtistsName = createArtist.ArtistsName, Description = createArtist.Description }, "artist");
        await Shell.Current.DisplayAlert("Create", "New artist created.", "OK");
        await GetArtistAsync();
    }

    [RelayCommand]
    async Task UpdateArtistAsync()
    {
        await restService.PutAsync<Artist>(selectedArtist, "artist");
        await Shell.Current.DisplayAlert("Update", "Update successful.", "OK");
        await GetArtistAsync();
    }

    [RelayCommand]
    async Task DeleteArtistAsync()
    {
        await restService.DeleteAsync(selectedArtist.ArtistsId, "artist");
        await Shell.Current.DisplayAlert("Delete", "Delete successful.", "OK");
        await GetArtistAsync();
    }

}