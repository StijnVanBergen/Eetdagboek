using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EetDagboek.Models
{
    public interface IModelRepo
    {
        Task AddMaaltijd(Maaltijd maaltijd);

        Task<List<Maaltijd>> GetMaaltijdenByDay(DateTime day);
    }
}
