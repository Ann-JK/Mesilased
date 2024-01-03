using Mesilased.Models;

namespace Mesilased.Views;

public partial class BeeSpecimenDetailsPage : ContentPage
{
    public BeeSpecimenDetailsPage(BeeSpecimen beespecimen)
    {
        InitializeComponent();
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}