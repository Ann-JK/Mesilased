using Mesilased.Models;

namespace Mesilased.Views;

public partial class BeesDetailsPage : ContentPage
{
	public BeesDetailsPage(Bees bees)
	{
		InitializeComponent();
	}

	async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}	

