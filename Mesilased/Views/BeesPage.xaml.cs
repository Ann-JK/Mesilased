using Mesilased.Models;
using Mesilased.Services;
using System.Numerics;

namespace Mesilased.Views;

public partial class BeesPage : ContentPage
{
	public BeesPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstAllBees.ItemsSource = BeesService.GetAllBees();
    }
    void ApiPic_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void Bees_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new BeesDetailsPage(e.CurrentSelection.First() as Bees));

    }
}


