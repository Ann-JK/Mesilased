
using Mesilased.Models;
using Mesilased.Services;

namespace Mesilased.Views;

public partial class BeeSpecimenPage : ContentPage
{
    public BeeSpecimenPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstAllBeeSpecimen.ItemsSource = BeeSpecimenService.GetAllBeeSpecimen();
    }

    void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void BeeSpecimen_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new BeeSpecimenDetailsPage(e.CurrentSelection.First() as BeeSpecimen));

    }
}