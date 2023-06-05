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
    public class WhatWeDoManager : IWhatWeDoService
    {
        private readonly IWhatWeDoDal _whatWeDoDal;

        public WhatWeDoManager(IWhatWeDoDal whatWeDoDal)
        {
            _whatWeDoDal = whatWeDoDal;
        }

        public void TDelete(WhatWeDo t)
        {
           _whatWeDoDal.Delete(t);
        }

        public WhatWeDo TGetByID(int id)
        {
            return _whatWeDoDal.GetByID(id);
        }

        public List<WhatWeDo> TGetList()
        {
            return _whatWeDoDal.GetList();
        }

        public void TInsert(WhatWeDo t)
        {
            _whatWeDoDal.Insert(t);
        }

        public void TUpdate(WhatWeDo t)
        {
            _whatWeDoDal.Update(t);
        }
    }
}
