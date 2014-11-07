using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KatanaWebAPI.Models
{
    public class ImagesModel
    {
        public List<string> Images { get; set; }

        public ImagesModel()
        {
            Images = new List<string>();
        }
    }
}
