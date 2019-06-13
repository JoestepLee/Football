using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data
{
    public interface IProvider
    {
        List<Team> TeamProvide();
    }
}
