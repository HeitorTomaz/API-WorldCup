using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_WorldCup.Models
{
    public class Scor
    {
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        //public int awayShots { get; set; }
        //public int homeShots { get; set; }
        //public int awayShotsOnGoal { get; set; }
        //public int homeShotsOnGoal { get; set; }
        public Boolean isShootout { get; set; }
        public int awayShootoutScore { get; set; }
        public int homeShootoutScore { get; set; }
    }
}
