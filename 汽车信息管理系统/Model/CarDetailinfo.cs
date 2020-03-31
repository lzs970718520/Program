using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarDetailinfo
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public string Content { get; set; }
        public int Price { get; set; }
        public int Price2 { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Ltime { get; set; }
        public int BrandId { get; set; }
    }
}
