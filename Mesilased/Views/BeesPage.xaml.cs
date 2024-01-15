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
                "Apis mellifera on tuntud kodumesilasena ja seda peetakse �heks t�htsaimaks tolmeldajaks maailmas." +
                " Need mesilased elavad suurtes kolooniates, kus on kuninganna, t��liste ja emasmesilased. Nad on p�rit Euroopast, " +
                "kuid on levinud paljudesse teistesse piirkondadesse inimese poolt toodetud tarude kaudu.\r\n\r\nKodumesilased on tihedalt seotud meetootmisega, " +
                "kogudes nektarit �itest ja muutes selle meeks tarus. Nende sotsiaalne struktuur ja keeruline side v�imaldavad neil t�husalt koguda toitu, " +
                "hooldada j�rglasi ja s�ilitada taru kui tervikut. " +
                "Kodumesilased on mitmek�lgsed tolmeldajad, " +
                "m�ngides olulist rolli paljude taimeliikide paljunemises ja �kos�steemide tasakaalu s�ilitamises"},

            new Bees { Name = "Liivamesilane", HeroImage = "andrena.jpg", ScientificName = "Andrena spp.",
                Description = 
                "Andrena spp. on laialt levinud metsamesilaste perekond, tuntud ka kui liivamesilased v�i maamesilased." +
                " Nad moodustavad �he suurima mesilaste perekonna ja on sageli seotud metsa- ja rohumaastikega." +
                " Nende erinevate liikide suurus ja v�rvus v�ivad oluliselt erineda." +
                "\r\n\r\nAndrena mesilased on m�rkimisv��rsed oma pesitsusmudelite poolest," +
                " sageli kaevates pesi mullas v�i kivide vahel. " +
                "Neil on erip�rane harjumus koguda toitu ainult teatud taimeliikidelt, " +
                "muutes nad olulisteks spetsialiseerunud tolmeldajateks. " +
                "Nende mesilaste emased hoolitsevad iseseisvalt pesade ehitamise ja munade paigutamise eest. " +
                "Andrena spp. on olulised osalised �kos�steemi tolmeldajad, " +
                "toetades mitmekesiste taimeliikide paljunemist."},

            new Bees { Name = "Lehemesilane", HeroImage = "lasio.jpg", ScientificName = "Lasioglossum spp.", 
                Description =
                "Lasioglossum spp. on lai perekond mesilasi, mida tuntakse ka kui lehemesilased. " +
                "Nad kuuluvad �hte suurde mesilaste perekonda, " +
                "mis on levinud kogu maailmas. " +
                "Nende mesilaste tunnusjooneks on tihe karvastik, " +
                "mis katab nende keha ja mida nad sageli koguvad pesa ehitamiseks ja toidu hoidmiseks." +
                "\r\n\r\nLasioglossum mesilased on m��dukalt suurte kolooniate moodustajad ning" +
                " nad ehitavad pesi sageli maa sisse v�i putukate n�riliste urkadesse. " +
                "Nende liigid on tuntud erinevate toitumisvalikute poolest, " +
                "kogudes nektarit ja �ietolmu mitmesugustelt taimedelt. " +
                "Lasioglossum spp. on olulised tolmeldajad, " +
                "m�ngides rolli looduslikes �kos�steemides ja toetades mitmekesiste taimeliikide paljunemist."},

            new Bees { Name = "Lehemetsamesilane", HeroImage = "megachile.jpg", ScientificName = "Megachile spp.", 
                Description =
                "Megachile spp. on mitmekesine mesilaste perekond, mida tuntakse ka kui lehemetsamesilased. " +
                "Nad on levinud �le maailma ja h�lmavad mitmeid liike, " +
                "mille suurus ja v�rvus v�ivad m�rkimisv��rselt erineda. " +
                "Nende mesilaste erip�raks on v�ime kasutada pesamaterjalina lehti." +
                "\r\n\r\nMegachile mesilased ehitavad pesi, kasutades lehti, " +
                "mida nad t�keldavad ja kujundavad pesa jaoks sobivaks. " +
                "Pesa ehitamiseks kasutavad nad s�lge, " +
                "et kinnitada lehtede t�kke kindlalt kokku. " +
                "Need mesilased on tuntud ka kui tubulitoomesilased, " +
                "sest nad moodustavad torujad pesad, " +
                "mis on sageli peidetud looduslikesse ��nsustesse v�i inimeste poolt loodud struktuuridesse. " +
                "Megachile spp. on olulised tolmeldajad, aidates kaasa mitmete taimeliikide paljunemisele ja �kos�steemide mitmekesisusele."}

        };
        BeesCollectionRight = new ObservableCollection<Bees>
        {
            new Bees { Name = "M��rimesilane", HeroImage = "osmia.jpg", ScientificName = "Osmia spp.", 
                Description =
                "Osmia spp. on mitmekesine mesilaste perekond, mida tuntakse ka kui m��rimesilasi v�i puumesilasi. " +
                "Neil mesilastel on tugev seos �kos�steemidega, " +
                "kus nad m�ngivad olulist rolli tolmeldajatena. " +
                "Osmia mesilased eristuvad teiste liikide poolest oma pesitsemise k�itumise ja elupaikade osas." +
                "\r\n\r\nOsmia mesilased ehitavad pesi tavaliselt looduslikes ��nsustes v�i kaevudes, " +
                "kasutades pesamaterjalina erinevaid aineid, nagu savi, muda v�i taimseid osakesi. " +
                "Nad on tuntud ka selle poolest, et nad tolmeldavad laialdaselt erinevaid taimi, " +
                "sealhulgas viljapuid ja marjap��said. " +
                "Osmia mesilastel on tihti lendamisel kiire ja " +
                "otsekohene liikumine ning nende v�limus v�ib varieeruda liigiti, " +
                "h�lmates erinevaid v�rve ja suurusi. " +
                "Nende unikaalne pesitsemisviis ja tolmeldamisaktiivsus muudavad nad oluliseks elemendiks �kos�steemide toimimisel ja taimede paljunemisel."},

            new Bees { Name = "Ahasmesilane", HeroImage = "halictus.jpg", ScientificName = "Halictus spp.", 
                Description =
                "Halictus spp. ehk ahasmesilased kuuluvad suurde mesilaste perekonda, " +
                "tuntud oma mitmekesisuse ja �koloogilise t�htsuse poolest. " +
                "Need mesilased on tavaliselt v�iksemad kui teised mesilased, " +
                "kuid neid leidub mitmesugustes elupaikades kogu maailmas, " +
                "eriti parasv��tme piirkondades." +
                "\r\n\r\nHigimullmesilaste kolooniad on tihti v�ikesed ja h�lmavad emasmesilast, " +
                "t��liste ja m�nikord ka isasmesilasi. " +
                "Nende nimi tuleneb sellest, et need mesilased eritavad pesa ehitamiseks s�lge, " +
                "mis k�vastub ja moodustab pesamaterjali. " +
                "Halictus spp. on olulised tolmeldajad, k�lastades mitmesuguseid �isi ja aidates kaasa taimede paljunemisele. " +
                "Nende mesilaste panus �kos�steemi toimimisse ja bioloogilisse mitmekesisusse on m�rkimisv��rne."},

            new Bees { Name = "Metsamesilane", HeroImage = "melitta.jpg", ScientificName = "Melitta spp.", 
                Description =
                "Melitta spp. on mesilaste perekond, tuntud ka kui metsamesilased v�i maamesilased. " +
                "Need mesilased erinevad kodumesilastest oma pesitsusmudelite ja elupaikade poolest. " +
                "Melitta mesilased eelistavad pesitseda maapinnal, " +
                "ehitades pesasid tihti lehtede v�i mullaga kaetud ��nsustesse." +
                "\r\n\r\nNende mesilaste kolooniad on tavaliselt suhteliselt v�ikesed ja koosnevad emasmesilastest ja t��listest." +
                " Melitta spp. ei tooda mett nagu kodumesilased, " +
                "kuid nad m�ngivad olulist rolli �kos�steemides, " +
                "tolmeldades erinevaid taimi. " +
                "Nende tolmeldamistegevus aitab kaasa taimede paljunemisele ja " +
                "�kos�steemi tasakaalu s�ilitamisele. " +
                "Melitta mesilased on kohastunud mitmekesiste elupaikadega, sealhulgas metsade, rohumaade ja aedadega."},

            new Bees { Name = "Lehel�ikur mesilane", HeroImage = "hylaeus.jpg", ScientificName = "Hylaeus spp.", 
                Description =
                "Hylaeus spp. mesilased, tuntud ka kui lehel�ikur mesilased, " +
                "moodustavad erilise mesilaste perekonna, " +
                "mille tunnusjooneks on nende kompaktne suurus ja enamasti must v�i tume kehav�rv. " +
                "Need mesilased erinevad teistest liikidest oma pesa ehitamise ja elupaikade poolest." +
                "\r\n\r\nHylaeus mesilased ehitavad pesi sageli pehmetesse puitudesse, " +
                "n�iteks kuivanud varre��nsustesse v�i ��nsatele v�rsetele. " +
                "Nad on tuntud ka oma erakordselt l�hikeste suude poolest, " +
                "mis on kohandunud suurep�raselt �ietolmu kogumiseks. " +
                "Kuigi nad ei tooda mett, m�ngivad Hylaeus spp. mesilased olulist rolli taimede tolmeldamisel, " +
                "sealhulgas paljude mets- ja aiataimede puhul. " +
                "Nende kohanemine erinevate elupaikadega ja " +
                "eriline k�itumine muudavad nad v��rtuslikeks osalisteks �kos�steemi toimimisel."}

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


