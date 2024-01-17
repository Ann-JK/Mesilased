using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesilased.Models
{
    public class BeeSpecimen
    {
        public string Name { get; set; }

        public string HeroImage { get; set; }
        public string Description { get; set; }

        public string Icon { get; set;}

        public List<string> Images { get; set; }

        public Brush Backround { get; set; }
    }
}
