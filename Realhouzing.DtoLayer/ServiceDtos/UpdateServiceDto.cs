using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realhouzing.DtoLayer.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
    }
}
