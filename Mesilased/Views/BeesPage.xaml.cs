using Mesilased.Models;
using Mesilased.Services;
using System.Collections.ObjectModel;
using System.Numerics;

namespace Mesilased.Views;

public partial class BeesPage : ContentPage
{

    public ObservableCollection<Bees> BeesCollectionLeft { get; set; }
    public ObservableCollection<Bees> BeesCollectionRight { get; set; }
    public BeesPage()
	{
        InitializeComponent();
        BeesCollectionLeft = new ObservableCollection<Bees>
        {
            new Bees { Name = "Meemesilane", HeroImage = "apis.jpg", ScientificName = "Apis Mellifera"},
            new Bees { Name = "Liivamesilane", HeroImage = "andrena.jpg", ScientificName = "Andrena spp."},
            new Bees { Name = "Lehemesilane", HeroImage = "lasio.jpg", ScientificName = "Lasioglossum spp."},
            new Bees { Name = "Hiidmesilane", HeroImage = "megachile.jpg", ScientificName = "Megachile spp."}

        };
        BeesCollectionRight = new ObservableCollection<Bees>
        {
            new Bees { Name = "Müürimesilane", HeroImage = "osmia.jpg", ScientificName = "Osmia spp."},
            new Bees { Name = "Poola", HeroImage = "halictus.jpg", ScientificName = "Halictus spp."},
            new Bees { Name = "Poola", HeroImage = "melitta.jpg"},
            new Bees { Name = "Poola", HeroImage = "hylaeus.jpg"}

        };

        BindingContext = this;

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


