using Endangered_animals.Data;
using Endangered_animals.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals.Utility
{
    public class RepositoryFactory:IRepositoryFactory
    {
        private readonly endangered_animalsDbContext dbContext;
        private static readonly RepositoryFactory instance = new RepositoryFactory();
        private RepositoryFactory() 
        {
            this.dbContext = new endangered_animalsDbContext();
        }
        
        public static RepositoryFactory Instance
        {
            get { return instance; }
        }

        public IRepository<T> CreateRepository<T>() where T : class
        {
            if(typeof(T)==typeof(Animal))
            {
                return new AnimalRepository(dbContext) as IRepository<T>;
            }
            else if (typeof(T) == typeof(Alimentatie))
            {
                return new AlimentatieRepository(dbContext) as IRepository<T>;
            }
            else if(typeof(T) == typeof(Categorie_Specie))
            {
                return new CategorieSpecieRepository(dbContext) as IRepository<T>;
            }
            else
            {
                throw new Exception("Unknown entity type!");
            }
        }
    }
}
