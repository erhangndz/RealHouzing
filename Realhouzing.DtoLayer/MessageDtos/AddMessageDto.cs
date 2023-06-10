using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realhouzing.DtoLayer.MessageDtos
{
    public class AddMessageDto
    {
        
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Content { get; set; }
    }
}
