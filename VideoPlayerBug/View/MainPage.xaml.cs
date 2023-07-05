using System.Collections.ObjectModel;
using VideoPlayerBug.Models;

namespace VideoPlayerBug.View;

public partial class MainPage : ContentPage
{
    ObservableCollection<MediaItem> Items = new System.Collections.ObjectModel.ObservableCollection<MediaItem>();
    public MainPage()
    {
        InitializeComponent();
        PrepareItems();
        mediaCarousel.ItemsSource = Items;
    }

    private void PrepareItems()
    {
        Items.Add(new MediaItem() 
        {
            IsVideo= false
        });

        Items.Add(new MediaItem()
        {
            IsVideo = true
        });

        Items.Add(new MediaItem()
        {
            IsVideo = false
        });
    }
}