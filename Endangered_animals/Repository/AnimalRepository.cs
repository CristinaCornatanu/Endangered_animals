using Endangered_animals.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    public class AnimalRepository: RepositoryBase<Animal>
    {
       

        public AnimalRepository(endangered_animalsDbContext context) : base( context)
        {
        }

      
    }
}
