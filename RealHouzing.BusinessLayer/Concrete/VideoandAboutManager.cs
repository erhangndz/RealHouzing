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
    public class VideoandAboutManager : IVideoandAboutService
    {
        private readonly IVideoandAboutDal _videoandAboutDal;

        public VideoandAboutManager(IVideoandAboutDal videoandAboutDal)
        {
            _videoandAboutDal = videoandAboutDal;
        }

        public void TDelete(VideoandAbout t)
        {
            _videoandAboutDal.Delete(t);
        }

        public VideoandAbout TGetByID(int id)
        {
            return _videoandAboutDal.GetByID(id);
        }

        public List<VideoandAbout> TGetList()
        {
            return _videoandAboutDal.GetList();
        }

        public void TInsert(VideoandAbout t)
        {
            _videoandAboutDal.Insert(t);
        }

        public void TUpdate(VideoandAbout t)
        {
            _videoandAboutDal.Update(t);
        }
    }
}
