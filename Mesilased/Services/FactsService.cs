using Mesilased.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesilased.Services
{
    internal class FactsService
    {
        public static List<Facts> facts = new()
        {
            new()
            {
                RandomFact = "Fact 1",
                Description = "Keskmine töömesilane toodab oma elu jooksul umbes 1/12 teelusikatäit mett."
            },
            new()
            {
                RandomFact = "Fact 2",
                Description = "Mesilane on ainus putukas, kes toodab toitu, mida söövad ka inimesed."
            },
            new()
            {
                RandomFact = "Fact 3",
                Description = "Mesilase tiivad liiguvad erakordselt kiiresti, tehes umbes 230 lööki sekundis – see tekitabki mesilastele iseloomulikku suminat. Mesilane võib lennata 10 kilomeetrit järjest ja 24 kilomeetrit tunnis."
            },
            new()
            {
                RandomFact = "Fact 4",
                Description = "Mesilasel on 170 lõhnaretseptorit (see on võrreldav näiteks 50kordse koera lõhnatundlikkusega) äädikakärbsel on 62, sääsel 79 lõhnaretseptorit."
            },
            new()
            {
                RandomFact = "Fact 5",
                Description = "Mesilased on Maal elanud umbes 30 miljonit aastat."
            },
            new()
            {
                RandomFact = "Fact 6",
                Description = "Mett leidus 2000 aasta vanustes Egiptuse püramiidides, see mesi oli endiselt täiesti söödav."
            },
            new()
            {
                RandomFact = "Fact 7",
                Description = "Et saada pool kilo mett, peavad 556 mesilast külastama kahte miljonit lilleõit."
            },
            new()
            {
                RandomFact = "Fact 8",
                Description = "Mesilased suhtlevad üksteisega kahel viisil: nad kasutavad lõhna eritavaid feromoone, et edastada sõnumit teistele mesilastele. Et juhatada teisi mesilasi õiteni, kasutavad mesilased ka spetsiaalset tantsu."
            },
            new()
            {
                RandomFact = "Fact 9",
                Description = "Mesilastel on kaht liiki silmad: kaks liitsilma on moodustunud tuhandetest läätsedest, lisaks on mesilase pea tagaküljel kolm lihtsilma."
            },
            new()
            {
                RandomFact = "Fact 10",
                Description = "Et saada kilogramm mett, töötavad 500 mesilast 4 nädalat ja läbivad teekonna, mis on võrreldav 3 tiiruga ümber maakera."
            }
        };
    }
}
