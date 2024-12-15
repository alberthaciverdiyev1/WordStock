using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDaL<T>
    {
        void Add(T item);
        void Delete (T item);
        void Update(T item);
        List<T> GetAll();
    }
}
