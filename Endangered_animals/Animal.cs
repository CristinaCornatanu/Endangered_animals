using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    public class Animal
    {
        public int IdAnimal { get; set; }
        public int SpeciesCategoryId { get; set; }
        public int DietId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public SpeciesCategory SpeciesCategory { get; set; }

        public Diet Diet { get; set; }
    }
}
