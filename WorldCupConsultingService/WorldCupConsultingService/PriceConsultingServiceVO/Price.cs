using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupConsultingServiceVO.Models
{
    public class Price
    {
        public string coin { get; set; }
        public Ticker ticker { get; set; }
    }

    public class Ticker
    {
        public string high { get; set; }
        public string low { get; set; }
        public string vol { get; set; }
        public string last { get; set; }
        public string buy { get; set; }
        public string sell { get; set; }
        public long date { get; set; }
    }
}
