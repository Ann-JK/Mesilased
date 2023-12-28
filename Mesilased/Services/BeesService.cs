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
                HeroImage = "",
                Description = "",
            },

            new()
            {
                Name = "Müürimesilane",
                ScientificName = "Osmia spp.",
                HeroImage = "",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Megachile spp.",
                HeroImage = "",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Andrena spp.",
                HeroImage = "",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Lasioglossum spp.",
                HeroImage = "",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Halictus spp.",
                HeroImage = "",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Hylaeus spp.",
                HeroImage = "",
                Description = "",
            },

            new()
            {
                Name = "Lehemesilane",
                ScientificName = "Melitta spp.",
                HeroImage = "",
                Description = "",
            },
        };

        public static List<Bees> GetAllBees() => bees;
    }
}
