using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals.Data
{
    public class endangered_animalsDbContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Alimentatie> Alimentatie { get; set; }
        public DbSet<Categorie_Specie> Categorie_Specie { get; set; }
        

        public endangered_animalsDbContext() : base("name=DbAniEnd")
        {
        }

    }
}
