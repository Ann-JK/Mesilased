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
                Description = "Mesimumm on triibuline"
            },
            new()
            {
                RandomFact = "Fact 2",
                Description = "Mesimumm nõelab"
            },
            new()
            {
                RandomFact = "Fact 3",
                Description = "Mesimumm annab mett"
            }
        };
    }
}
