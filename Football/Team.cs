using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Area Area { get; set; }
        public int TotalScore { get; set; }
        public List<Player> PlayerList { get; set; }
    }
}
