using Mesilased.Models;

namespace Mesilased.Views;

public partial class BeesDetailsPage : ContentPage
{
	public BeesDetailsPage(Bees bees)
	{
		InitializeComponent();

		this.BindingContext = bees;
	}

	async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}	

