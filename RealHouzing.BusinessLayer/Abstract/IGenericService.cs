using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        T TGetByID(int id);
        List<T> TGetList();
        void TDelete(T t);
        void TUpdate(T t);
        void TInsert(T t);
    }
}
