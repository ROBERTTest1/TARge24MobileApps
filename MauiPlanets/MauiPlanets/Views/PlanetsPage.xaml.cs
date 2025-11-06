using MauiPlanets.Models;
using MauiPlanets.Services;

namespace MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
    private const uint AnimationDuration = 800u;

    public PlanetsPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

    async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection?.FirstOrDefault() is Planet selectedPlanet && Navigation != null)
        {
            // TODO: Navigate to PlanetDetailsPage when created
            // await Navigation.PushAsync(new PlanetDetailsPage(selectedPlanet));
        }
        
        // Clear selection to allow re-selection
        if (sender is CollectionView collectionView)
        {
            collectionView.SelectedItem = null;
        }
    }


    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        _ = MainContentGrid.ScaleTo(0.8, AnimationDuration);
    }
}

