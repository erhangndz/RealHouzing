using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        T GetByID(int id);
        List<T> GetList();
        void Delete(T t);
        void Update(T t);
        void Insert(T t);
    }
}
