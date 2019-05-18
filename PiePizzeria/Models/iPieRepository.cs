using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiePizzeria.Models
{
    public interface iPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
