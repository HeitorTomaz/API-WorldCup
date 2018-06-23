using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupConsultingServiceVO.Models
{
    public class FoxResponse
    {
        public List<Game> page { get; set; }
        public int totalCount { get; set; }
        public int pageSize { get; set; }
    }
}
