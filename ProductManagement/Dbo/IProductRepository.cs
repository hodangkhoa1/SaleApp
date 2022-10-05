using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Dbo
{
    public interface IProductRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(int id);
        void Update(T entity);
        T GetById(int id);
        List<T> Search(string name);
        List<T> Get();
    }
}
