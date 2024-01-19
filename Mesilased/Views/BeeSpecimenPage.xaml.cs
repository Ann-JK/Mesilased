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
                Name = "T��mesilane",
                HeroImage = "t66mesilane.png",
                Description =
                "T��mesilane on viljatu emasmesilane, kes teeb tarus k�ik t��d. Tema �lesanne on nii vaklade toitmine, koristamine, pesa kaitsmine," +
                "mee valmistamine kui ka nektari korjamine. T��mesilasi on tarus olenevalt aastaajast 30 000 � 80 000 isendit. T��mesilased elavad korjeperioodil " +
                "keskmiselt 35�45 p�eva, talvel aga kuni 8 kuud. T��mesilane on lesest ja mesilasemast v�iksem. T��mesilased arenevad viljastatud munadest. " +
                " Hauet toidetakse kolm p�eva ematoitepiimaga ja p�rast seda hakatakse andma suira ja mee segu. T��mesilase areng munast kuni valmikuni kestab 21 p�eva.",
                Icon = "t66mesilane_ikoon.png"
            },

            new BeeSpecimen
            {
                Name = "Emamesilane",
                HeroImage = "emamesilane.png",
                Description =
                "T��mesilane on viljatu emasmesilane, kes teeb tarus k�ik t��d. Tema �lesanne on nii vaklade toitmine, koristamine, pesa kaitsmine," +
                "mee valmistamine kui ka nektari korjamine. T��mesilasi on tarus olenevalt aastaajast 30 000 � 80 000 isendit. T��mesilased elavad korjeperioodil " +
                "keskmiselt 35�45 p�eva, talvel aga kuni 8 kuud. T��mesilane on lesest ja mesilasemast v�iksem. T��mesilased arenevad viljastatud munadest. " +
                " Hauet toidetakse kolm p�eva ematoitepiimaga ja p�rast seda hakatakse andma suira ja mee segu. T��mesilase areng munast kuni valmikuni kestab 21 p�eva.",
                Icon = "emamesilane_ikoon.png"

            },

            new BeeSpecimen
            {
                Name = "Lesk",
                HeroImage = "lesk.png",
                Description =
                "Lesk on j�medam ja pikem kui t��mesilane ja l�hem kui mesilasema. " +
                "Tal on mesilasemast ja t��mesilasest parem n�gemine, mis on vajalik paarituslennul mesilasema leidmiseks. Tal puudub astel. " +
                "Igas mesilasperes on tavaliselt paarsada leske, kes osalevad pere elutegevuses ainult kevadest s�giseni. " +
                "Lesed ei tegele korjega, kuid 1 kg leski on oma tarus elatud paari kuu jooksul suuteline �ra s��ma kuni 20 kg mett. ",
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
