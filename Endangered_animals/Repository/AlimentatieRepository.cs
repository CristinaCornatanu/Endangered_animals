using Endangered_animals.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    public class AlimentatieRepository: RepositoryBase<Alimentatie>
    {
        public AlimentatieRepository(endangered_animalsDbContext context):base(context) 
        { 

        }


    }
}
