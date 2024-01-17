using Mesilased.Models;

namespace Mesilased.Views;

public partial class BeeSpecimenDetailsPage : ContentPage
{
    public BeeSpecimenDetailsPage(BeeSpecimen specimen)
    {
        InitializeComponent();

        this.BindingContext = specimen;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}