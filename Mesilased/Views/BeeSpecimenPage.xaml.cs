using Mesilased.Models;
using System.Collections.ObjectModel;


namespace Mesilased.Views;

public partial class BeeSpecimenPage : ContentPage
{
    public ObservableCollection<BeeSpecimen> BeeSpecimenCollection { get; set; }
    public BeeSpecimenPage()
	{
		InitializeComponent();

        BeeSpecimenCollection = new ObservableCollection<BeeSpecimen>
        {
            new BeeSpecimen
            {
                Name = "Töömesilane",
                HeroImage = "t66mesilane.png",
                Description =
                "Töömesilane on viljatu emasmesilane, kes teeb tarus kõik tööd. Tema ülesanne on nii vaklade toitmine, koristamine, pesa kaitsmine," +
                "mee valmistamine kui ka nektari korjamine. Töömesilasi on tarus olenevalt aastaajast 30 000 – 80 000 isendit. Töömesilased elavad korjeperioodil " +
                "keskmiselt 35–45 päeva, talvel aga kuni 8 kuud. Töömesilane on lesest ja mesilasemast väiksem. Töömesilased arenevad viljastatud munadest. " +
                " Hauet toidetakse kolm päeva ematoitepiimaga ja pärast seda hakatakse andma suira ja mee segu. Töömesilase areng munast kuni valmikuni kestab 21 päeva.",
                Icon = "t66mesilane_ikoon.png"
            },

            new BeeSpecimen
            {
                Name = "Emamesilane",
                HeroImage = "emamesilane.png",
                Description =
                "Töömesilane on viljatu emasmesilane, kes teeb tarus kõik tööd. Tema ülesanne on nii vaklade toitmine, koristamine, pesa kaitsmine," +
                "mee valmistamine kui ka nektari korjamine. Töömesilasi on tarus olenevalt aastaajast 30 000 – 80 000 isendit. Töömesilased elavad korjeperioodil " +
                "keskmiselt 35–45 päeva, talvel aga kuni 8 kuud. Töömesilane on lesest ja mesilasemast väiksem. Töömesilased arenevad viljastatud munadest. " +
                " Hauet toidetakse kolm päeva ematoitepiimaga ja pärast seda hakatakse andma suira ja mee segu. Töömesilase areng munast kuni valmikuni kestab 21 päeva.",
                Icon = "emamesilane_ikoon.png"

            },

            new BeeSpecimen
            {
                Name = "Lesk",
                HeroImage = "lesk.png",
                Description =
                "Lesk on jämedam ja pikem kui töömesilane ja lühem kui mesilasema. " +
                "Tal on mesilasemast ja töömesilasest parem nägemine, mis on vajalik paarituslennul mesilasema leidmiseks. Tal puudub astel. " +
                "Igas mesilasperes on tavaliselt paarsada leske, kes osalevad pere elutegevuses ainult kevadest sügiseni. " +
                "Lesed ei tegele korjega, kuid 1 kg leski on oma tarus elatud paari kuu jooksul suuteline ära sööma kuni 20 kg mett. ",
                Icon = "lesk_ikoon.png"


            }


        };

        BindingContext = this;
    }
    async void BeeSpecimen_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new BeeSpecimenDetailsPage(e.CurrentSelection.First() as BeeSpecimen));

    }
    private void Esileht(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    private async void InfoButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InfoPage());
    }
}
