using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EetDagboek.Models
{
    public interface IModelRepo
    {
        Task<Maaltijd> GetMaaltijdByDay(DateTime day, string titel);
        Task AddMaaltijd(Maaltijd maaltijd);
        Task<List<Maaltijd>> GetAllMaaltijdenByDay(DateTime day);
    }
}
