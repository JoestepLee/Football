using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public abstract class Round
    {
        public List<Match> MatchList { get; set; }
        public List<Team> InputTeams { get; set; }
        public abstract List<Team> Play();

    }
}
