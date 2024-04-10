using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals.Interface
{
    public interface IRepositoryFactory
    {
        IRepository<T> CreateRepository<T>()where T : class;
    }
}
