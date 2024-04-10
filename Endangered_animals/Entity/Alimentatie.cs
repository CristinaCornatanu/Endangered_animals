using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    [Table("Alimentatie")]
    public class Alimentatie
    {
        [Column("id_tip_alimentatie")]
        public int Id { get; set; }
        public string tip_alimentatie { get; set; }
        public string descriere { get; set; }

    }
}
