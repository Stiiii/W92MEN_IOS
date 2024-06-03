using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MusicManagerMAUI;

public partial class MainPageViewModel : ObservableObject
{
    RestService restService = new RestService("https://localhost:7254/", "Album");

    [ObservableProperty]
    ObservableCollection<Album> albums;

    [ObservableProperty]
    Album selectedAlbum;

    [ObservableProperty]
    Album createAlbum;

    [ObservableProperty]
    bool isBusy;

    public MainPageViewModel()
    {
        albums = new ObservableCollection<Album>();
        createAlbum = new Album();
        GetAlbumsAsync();
    }

    async Task GetAlbumsAsync()
    {
        IsBusy = true;
        albums.Clear();
        var list = await restService.GetAsync<Album>("album");
        list.ForEach(x => albums.Add(x));
        IsBusy = false;
    }

    [RelayCommand]
    async Task CreateAlbumAsync()
    {
        await restService.PostAsync<Album>(new Album() { AlbumName = CreateAlbum.AlbumName, Artist = CreateAlbum.Artist }, "album");
        await Shell.Current.DisplayAlert("Create", "New album created.", "OK");
        await GetAlbumsAsync();
    }

    [RelayCommand]
    async Task UpdateAlbumAsync()
    {
        await restService.PutAsync<Album>(SelectedAlbum, "album");
        await Shell.Current.DisplayAlert("Update", "Update successful.", "OK");
        await GetAlbumsAsync();
    }

    [RelayCommand]
    async Task DeleteAlbumAsync()
    {
        await restService.DeleteAsync(SelectedAlbum.AlbumId, "album");
        await Shell.Current.DisplayAlert("Delete", "Delete successful.", "OK");
        await GetAlbumsAsync();
    }


}