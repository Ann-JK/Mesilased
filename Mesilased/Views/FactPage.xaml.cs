namespace Mesilased.Views;

public partial class FactPage : ContentPage
{
	public string randomFact
	{
		get
		{
			var random = new Random();
			var f = Services.FactsService.facts;
			return f[random.Next(0, f.Count)].Description;
		}
	}


	public FactPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

    private void Esileht(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }
}