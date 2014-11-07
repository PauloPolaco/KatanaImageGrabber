
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KatanaService
{
    public class ImagesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            yield return @"..\Img\A.jpg";
            yield return @"..\Img\B.jpg";
            yield return @"..\Img\C.jpg";
        }
    }
}
