using Mesilased.Models;
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
            new Bees { Name = "Meemesilane", HeroImage = "apis.jpg", ScientificName = "Apis Mellifera", 
                Description =
                "Apis mellifera on tuntud kodumesilasena ja seda peetakse üheks tähtsaimaks tolmeldajaks maailmas." +
                " Need mesilased elavad suurtes kolooniates, kus on kuninganna, tööliste ja emasmesilased. Nad on pärit Euroopast, " +
                "kuid on levinud paljudesse teistesse piirkondadesse inimese poolt toodetud tarude kaudu.\r\n\r\nKodumesilased on tihedalt seotud meetootmisega, " +
                "kogudes nektarit õitest ja muutes selle meeks tarus. Nende sotsiaalne struktuur ja keeruline side võimaldavad neil tõhusalt koguda toitu, " +
                "hooldada järglasi ja säilitada taru kui tervikut. " +
                "Kodumesilased on mitmekülgsed tolmeldajad, " +
                "mängides olulist rolli paljude taimeliikide paljunemises ja ökosüsteemide tasakaalu säilitamises"},

            new Bees { Name = "Liivamesilane", HeroImage = "andrena.jpg", ScientificName = "Andrena spp.",
                Description = 
                "Andrena spp. on laialt levinud metsamesilaste perekond, tuntud ka kui liivamesilased või maamesilased." +
                " Nad moodustavad ühe suurima mesilaste perekonna ja on sageli seotud metsa- ja rohumaastikega." +
                " Nende erinevate liikide suurus ja värvus võivad oluliselt erineda." +
                "\r\n\r\nAndrena mesilased on märkimisväärsed oma pesitsusmudelite poolest," +
                " sageli kaevates pesi mullas või kivide vahel. " +
                "Neil on eripärane harjumus koguda toitu ainult teatud taimeliikidelt, " +
                "muutes nad olulisteks spetsialiseerunud tolmeldajateks. " +
                "Nende mesilaste emased hoolitsevad iseseisvalt pesade ehitamise ja munade paigutamise eest. " +
                "Andrena spp. on olulised osalised ökosüsteemi tolmeldajad, " +
                "toetades mitmekesiste taimeliikide paljunemist."},

            new Bees { Name = "Lehemesilane", HeroImage = "lasio.jpg", ScientificName = "Lasioglossum spp.", 
                Description =
                "Lasioglossum spp. on lai perekond mesilasi, mida tuntakse ka kui lehemesilased. " +
                "Nad kuuluvad ühte suurde mesilaste perekonda, " +
                "mis on levinud kogu maailmas. " +
                "Nende mesilaste tunnusjooneks on tihe karvastik, " +
                "mis katab nende keha ja mida nad sageli koguvad pesa ehitamiseks ja toidu hoidmiseks." +
                "\r\n\r\nLasioglossum mesilased on mõõdukalt suurte kolooniate moodustajad ning" +
                " nad ehitavad pesi sageli maa sisse või putukate näriliste urkadesse. " +
                "Nende liigid on tuntud erinevate toitumisvalikute poolest, " +
                "kogudes nektarit ja õietolmu mitmesugustelt taimedelt. " +
                "Lasioglossum spp. on olulised tolmeldajad, " +
                "mängides rolli looduslikes ökosüsteemides ja toetades mitmekesiste taimeliikide paljunemist."},

            new Bees { Name = "Lehemetsamesilane", HeroImage = "megachile.jpg", ScientificName = "Megachile spp.", 
                Description =
                "Megachile spp. on mitmekesine mesilaste perekond, mida tuntakse ka kui lehemetsamesilased. " +
                "Nad on levinud üle maailma ja hõlmavad mitmeid liike, " +
                "mille suurus ja värvus võivad märkimisväärselt erineda. " +
                "Nende mesilaste eripäraks on võime kasutada pesamaterjalina lehti." +
                "\r\n\r\nMegachile mesilased ehitavad pesi, kasutades lehti, " +
                "mida nad tükeldavad ja kujundavad pesa jaoks sobivaks. " +
                "Pesa ehitamiseks kasutavad nad sülge, " +
                "et kinnitada lehtede tükke kindlalt kokku. " +
                "Need mesilased on tuntud ka kui tubulitoomesilased, " +
                "sest nad moodustavad torujad pesad, " +
                "mis on sageli peidetud looduslikesse õõnsustesse või inimeste poolt loodud struktuuridesse. " +
                "Megachile spp. on olulised tolmeldajad, aidates kaasa mitmete taimeliikide paljunemisele ja ökosüsteemide mitmekesisusele."}

        };
        BeesCollectionRight = new ObservableCollection<Bees>
        {
            new Bees { Name = "Müürimesilane", HeroImage = "osmia.jpg", ScientificName = "Osmia spp.", 
                Description =
                "Osmia spp. on mitmekesine mesilaste perekond, mida tuntakse ka kui müürimesilasi või puumesilasi. " +
                "Neil mesilastel on tugev seos ökosüsteemidega, " +
                "kus nad mängivad olulist rolli tolmeldajatena. " +
                "Osmia mesilased eristuvad teiste liikide poolest oma pesitsemise käitumise ja elupaikade osas." +
                "\r\n\r\nOsmia mesilased ehitavad pesi tavaliselt looduslikes õõnsustes või kaevudes, " +
                "kasutades pesamaterjalina erinevaid aineid, nagu savi, muda või taimseid osakesi. " +
                "Nad on tuntud ka selle poolest, et nad tolmeldavad laialdaselt erinevaid taimi, " +
                "sealhulgas viljapuid ja marjapõõsaid. " +
                "Osmia mesilastel on tihti lendamisel kiire ja " +
                "otsekohene liikumine ning nende välimus võib varieeruda liigiti, " +
                "hõlmates erinevaid värve ja suurusi. " +
                "Nende unikaalne pesitsemisviis ja tolmeldamisaktiivsus muudavad nad oluliseks elemendiks ökosüsteemide toimimisel ja taimede paljunemisel."},

            new Bees { Name = "Ahasmesilane", HeroImage = "halictus.jpg", ScientificName = "Halictus spp.", 
                Description =
                "Halictus spp. ehk ahasmesilased kuuluvad suurde mesilaste perekonda, " +
                "tuntud oma mitmekesisuse ja ökoloogilise tähtsuse poolest. " +
                "Need mesilased on tavaliselt väiksemad kui teised mesilased, " +
                "kuid neid leidub mitmesugustes elupaikades kogu maailmas, " +
                "eriti parasvöötme piirkondades." +
                "\r\n\r\nHigimullmesilaste kolooniad on tihti väikesed ja hõlmavad emasmesilast, " +
                "tööliste ja mõnikord ka isasmesilasi. " +
                "Nende nimi tuleneb sellest, et need mesilased eritavad pesa ehitamiseks sülge, " +
                "mis kõvastub ja moodustab pesamaterjali. " +
                "Halictus spp. on olulised tolmeldajad, külastades mitmesuguseid õisi ja aidates kaasa taimede paljunemisele. " +
                "Nende mesilaste panus ökosüsteemi toimimisse ja bioloogilisse mitmekesisusse on märkimisväärne."},

            new Bees { Name = "Metsamesilane", HeroImage = "melitta.jpg", ScientificName = "Melitta spp.", 
                Description =
                "Melitta spp. on mesilaste perekond, tuntud ka kui metsamesilased või maamesilased. " +
                "Need mesilased erinevad kodumesilastest oma pesitsusmudelite ja elupaikade poolest. " +
                "Melitta mesilased eelistavad pesitseda maapinnal, " +
                "ehitades pesasid tihti lehtede või mullaga kaetud õõnsustesse." +
                "\r\n\r\nNende mesilaste kolooniad on tavaliselt suhteliselt väikesed ja koosnevad emasmesilastest ja töölistest." +
                " Melitta spp. ei tooda mett nagu kodumesilased, " +
                "kuid nad mängivad olulist rolli ökosüsteemides, " +
                "tolmeldades erinevaid taimi. " +
                "Nende tolmeldamistegevus aitab kaasa taimede paljunemisele ja " +
                "ökosüsteemi tasakaalu säilitamisele. " +
                "Melitta mesilased on kohastunud mitmekesiste elupaikadega, sealhulgas metsade, rohumaade ja aedadega."},

            new Bees { Name = "Lehelõikur mesilane", HeroImage = "hylaeus.jpg", ScientificName = "Hylaeus spp.", 
                Description =
                "Hylaeus spp. mesilased, tuntud ka kui lehelõikur mesilased, " +
                "moodustavad erilise mesilaste perekonna, " +
                "mille tunnusjooneks on nende kompaktne suurus ja enamasti must või tume kehavärv. " +
                "Need mesilased erinevad teistest liikidest oma pesa ehitamise ja elupaikade poolest." +
                "\r\n\r\nHylaeus mesilased ehitavad pesi sageli pehmetesse puitudesse, " +
                "näiteks kuivanud varreõõnsustesse või õõnsatele võrsetele. " +
                "Nad on tuntud ka oma erakordselt lühikeste suude poolest, " +
                "mis on kohandunud suurepäraselt õietolmu kogumiseks. " +
                "Kuigi nad ei tooda mett, mängivad Hylaeus spp. mesilased olulist rolli taimede tolmeldamisel, " +
                "sealhulgas paljude mets- ja aiataimede puhul. " +
                "Nende kohanemine erinevate elupaikadega ja " +
                "eriline käitumine muudavad nad väärtuslikeks osalisteks ökosüsteemi toimimisel."}

        };

        BindingContext = this;

    }

    async void Bees_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new BeesDetailsPage(e.CurrentSelection.First() as Bees));

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


