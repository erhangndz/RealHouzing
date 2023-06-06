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
    public class PostingManager : IPostingService
    {
        private readonly IPostingDal _postingDal;

        public PostingManager(IPostingDal postingDal)
        {
            _postingDal = postingDal;
        }

        public void TDelete(Posting t)
        {
            _postingDal.Delete(t);
        }

        public Posting TGetByID(int id)
        {
           return _postingDal.GetByID(id);
        }

        public List<Posting> TGetList()
        {
            return _postingDal.GetList();
        }

        public void TInsert(Posting t)
        {
            _postingDal.Insert(t);
        }

        public void TUpdate(Posting t)
        {
            _postingDal.Update(t);
        }
    }
}
