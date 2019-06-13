using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class FinalRound:Round
    {
        Random rand = new Random();
        public override List<Team> Play()
        {
            MatchList = new List<Match>()
            {
                new Match()
                {
                    TeamA = InputTeams[0],
                    TeamB = InputTeams[1],
                    Date = DateTime.Now,
                }
            };
            MatchList[0].RandomPlay(rand);
            return new List<Team>() { MatchList[0].Winner };
        }
    }
}
