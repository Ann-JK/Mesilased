using Mesilased.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesilased.Services
{
    internal static class BeeSpecimenService
    {
        private static List<BeeSpecimen> beespecimen = new()
        {

            new()
            {
                Name = "Emamesilane",
                HeroImage = "emamesilane.png",
                Description = "",
            },

            new()
            {
                Name = "Lesk",
                HeroImage = "lesk.png",
                Description = "",
            },

            new()
            {
                Name = "Töömesilane",
                HeroImage = "t66mesilane.png",
                Description = "",
            },
        };

        public static List<BeeSpecimen> GetAllBeeSpecimen() => beespecimen;

    }
}