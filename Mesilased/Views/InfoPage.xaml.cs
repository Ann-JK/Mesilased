namespace Mesilased.Views;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void Patreon_Clicked(System.Object sender, System.EventArgs e)
    {
        Launcher.OpenAsync(new Uri("http://www.patreon.com"));
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e) 
    {
        await Navigation.PopAsync();
    }

}