using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public string Writer { get; set; }
        public string WriterImage { get; set; }
        public DateTime Date { get; set; }
    }
}
