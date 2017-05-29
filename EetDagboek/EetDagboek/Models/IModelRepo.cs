using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EetDagboek.Models
{
    public interface IModelRepo
    {
        Task<Dag> GetOneDay(DateTime dag);
        Task<List<Dag>> GetAllDays();
        Task<Maaltijd> GetMaaltijdByDay(DateTime day, string titel);
        Task AddMaaltijd(Maaltijd maaltijd);
        Task AddDag(Dag dag);
        Task<List<Maaltijd>> GetAllMaaltijdenByDay(DateTime day);
    }
}
