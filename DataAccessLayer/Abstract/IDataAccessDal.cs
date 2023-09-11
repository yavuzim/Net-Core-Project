using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDataAccessDal<T> where T : class
    {
        List<T> ListAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
    }
}
