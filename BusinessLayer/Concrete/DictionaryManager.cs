using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDictionaryService = BusinessLayer.Abstract.IDictionaryService;

namespace BusinessLayer.Concrete
{
    public class DictionaryManager : IDictionaryService
    {
        private readonly IDictionaryDAL _dictionary;

        public DictionaryManager(IDictionaryDAL dictionary)
        {
            _dictionary = dictionary;
        }
        public List<Dictionary> GetAll()
        {
            return _dictionary.GetAll();
        }

        public void TAdd(Dictionary entity)
        {
            _dictionary.Add(entity);
        }

        public void TRemove(Dictionary entity)
        {
            _dictionary.Delete(entity);
        }

        public void TUpdate(Dictionary entity)
        {
            _dictionary.Update(entity);
        }
    }
}
