using Mesilased.Views;

namespace Mesilased;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void ButtonClicked(object sender, EventArgs e)
    {
    }
    private void Nupp1Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new BeesPage());
    }
    private void Nupp2Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new FactPage());
    }
    private void Nupp3Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new FactPage());
    }
}

