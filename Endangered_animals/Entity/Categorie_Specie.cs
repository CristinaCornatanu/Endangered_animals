using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    [Table("Categorie_Specie")]
    public class Categorie_Specie
    {
        [Column("id_specie")]
        public int Id { get; set; }
        [Column("nume_specie")]
        public string SpecieName { get; set; }
    }
}
