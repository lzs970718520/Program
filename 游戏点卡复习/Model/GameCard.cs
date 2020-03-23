using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameCard
    {
        public int cardid { get; set; }
        public string gamename { get; set; }
        public string company { get; set; }
        public DateTime lastDay { get; set; }
        public float price { get; set; }

    }
}
 