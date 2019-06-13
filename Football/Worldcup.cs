using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Football.Data;

namespace Football
{
    public class Worldcup
    {
        public IProvider TeamProvider { get; set; }
        public List<Round> RoundList { get; set; }

        public List<Team> TeamList
        {
            get
            {
                return TeamProvider.TeamProvide();
            }
        }
        public Team Championship
        {
            get
            {
                return championship;
            }
        }

        private Team championship;

        public Worldcup()
        {
            RoundList = new List<Round>();
        }

        public void Play()
        {
            List<Team> previousResult = TeamList;
            foreach (Round round in RoundList)
            {
                round.InputTeams = previousResult;
                previousResult = round.Play();
            }
            this.championship = previousResult[0];
        }
    }
}
