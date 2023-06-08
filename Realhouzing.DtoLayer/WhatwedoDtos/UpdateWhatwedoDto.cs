using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realhouzing.DtoLayer.WhatwedoDtos
{
    public class UpdateWhatwedoDto
    {
        public int WhatWeDoID { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
    }
}
