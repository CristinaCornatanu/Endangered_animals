﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    [Table("Animal")]
    public class Animal 
    {
        [Column("id_animal")]
        public int Id{ get; set; }
        [Column("id_specie")]
        public int IdSpecie { get; set; }
        

        [Column("id_tip_alimentatie")]
        public int IdTipAlimentatie { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("descriere")]
        public string Descriere { get; set; }
        [Column("imagine")]
        public byte[] Imagine { get; set; }

        [ForeignKey("IdSpecie")]
        public Categorie_Specie Categorie_Specie { get; set; }
        [ForeignKey("IdTipAlimentatie")]
        public Alimentatie Alimentatie { get; set; }

    }
}
