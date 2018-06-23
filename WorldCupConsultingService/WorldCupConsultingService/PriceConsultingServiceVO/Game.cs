using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupConsultingServiceVO.Models
{

    public class Game
    {
        public int competitionId { get; set; }
        public DateTime date { get; set; }
        public DateTime utcDate { get; set; }
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public Scor score { get; set; }
        public Stat status { get; set; }
    }
}
