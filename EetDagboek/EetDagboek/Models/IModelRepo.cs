using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EetDagboek.Models
{
    public interface IModelRepo
    {
        Task<Dag> GetOneDay();
        Task<List<Dag>> GetAllDays();
        Task<Maaltijd> GetMaaltijdenByID(int DagID);
        Task<Maaltijd> GetMaaltijdByDay(DateTime day);
        Task AddMaaltijd(Maaltijd maaltijd);
        Task AddDag(Dag dag);
    }
}
