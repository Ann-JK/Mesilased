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
        //count++;

        //if (count == 1)
        //	nupp1.text = $"clicked {count} time";
        //else
        //	nupp1.text = $"clicked {count} times";

        //semanticscreenreader.announce(nupp1.text);

        //async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        //=> Application.Current.MainPage = new NavigationPage(new PlanetsPage());

        //async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        //=> Application.Current.MainPage = new NavigationPage(new PlanetsPage());

        //async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        //=> Application.Current.MainPage = new NavigationPage(new PlanetsPage());
    }
    private void Nupp1Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new FactPage());
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

