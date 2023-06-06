using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class BuyLeaseManager : IBuyLeaseService
    {
        private readonly IBuyLeaseDal _buyLeaseDal;

        public BuyLeaseManager(IBuyLeaseDal buyLeaseDal)
        {
            _buyLeaseDal = buyLeaseDal;
        }

        public void TDelete(BuyLease t)
        {
            _buyLeaseDal.Delete(t);
        }

        public BuyLease TGetByID(int id)
        {
           return _buyLeaseDal.GetByID(id);
        }

        public List<BuyLease> TGetList()
        {
            return _buyLeaseDal.GetList();
        }

        public void TInsert(BuyLease t)
        {
           _buyLeaseDal.Insert(t);
        }

        public void TUpdate(BuyLease t)
        {
            _buyLeaseDal.Update(t);
        }
    }
}
