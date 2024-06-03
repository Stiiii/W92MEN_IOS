using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MusicManagerMAUI;

public partial class RatingPageViewModel : ObservableObject
{
    RestService restService = new RestService("https://localhost:7254/", "Rating");

    [ObservableProperty]
    ObservableCollection<Ratings> ratings;

    [ObservableProperty]
    Ratings selectedRating;

    [ObservableProperty]
    Ratings createRating;

    [ObservableProperty]
    bool isBusy;

    public RatingPageViewModel()
    {
        ratings = new ObservableCollection<Ratings>();
        createRating = new Ratings();
        GetRatingAsync();
    }

    async Task GetRatingAsync()
    {
        IsBusy = true;
        ratings.Clear();
        var list = await restService.GetAsync<Ratings>("Rating");
        list.ForEach(x => ratings.Add(x));
        IsBusy = false;
    }

    [RelayCommand]
    async Task CreateRatingAsync()
    {
        await restService.PostAsync<Ratings>(new Ratings() { Rating = createRating.Rating, AlbumId = createRating.AlbumId }, "rating");
        await Shell.Current.DisplayAlert("Create", "New rating created.", "OK");
        await GetRatingAsync();
    }

    [RelayCommand]
    async Task UpdateRatingAsync()
    {
        await restService.PutAsync<Ratings>(selectedRating, "rating");
        await Shell.Current.DisplayAlert("Update", "Update successful.", "OK");
        await GetRatingAsync();
    }

    [RelayCommand]
    async Task DeleteRatingAsync()
    {
        await restService.DeleteAsync(selectedRating.RatingId, "rating");
        await Shell.Current.DisplayAlert("Delete", "Delete successful.", "OK");
        await GetRatingAsync();
    }

}