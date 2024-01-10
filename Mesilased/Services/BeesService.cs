using Mesilased.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesilased.Services
{
    internal static class BeesService
    {
        private static List<Bees> bees = new()
        {

            new()
            {
                Name = "Meemesilane",
                ScientificName = "Apis Mellifera",
                HeroImage = "apis.jpg",
                Description = "",
            },

            new()
            {
                Name = "Müürimesilane",
                ScientificName = "Osmia spp.",
                HeroImage = "osmia.jpg",
                Description = "",
            },

            new()
            {
                Name = "Hiidmesilane",
                ScientificName = "Megachile spp.",
                HeroImage = "megachile.jpg",
                Description = "",
            },

            new()
            {
                Name = "Liivamesilane",
                ScientificName = "Andrena spp.",
                HeroImage = "andrena.jpg",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Lasioglossum spp.",
                HeroImage = "lasio.jpg",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Halictus spp.",
                HeroImage = "halictus.jpg",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Hylaeus spp.",
                HeroImage = "hylaeus.jpg",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Melitta spp.",
                HeroImage = "melitta.jpg",
                Description = "",
            },
        };

        public static List<Bees> GetAllBees() => bees;
    }
}
