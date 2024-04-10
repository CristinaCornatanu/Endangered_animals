
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    public interface IRepository<T>
    {
        T Create(T entity);
        T Read(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
