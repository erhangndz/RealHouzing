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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TDelete(Blog t)
        {
           _blogDal.Delete(t);
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetByID(id);
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetList();
        }

        public void TInsert(Blog t)
        {
           _blogDal.Insert(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
