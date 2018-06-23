using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupConsultingServiceVO.Models
{
    public class Scor
    {
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public int awayShots { get; set; }
        public int homeShots { get; set; }
        public int awayShotsOnGoal { get; set; }
        public int homeShotsOnGoal { get; set; }
    }
}
