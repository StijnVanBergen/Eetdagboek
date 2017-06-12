using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EetDagboek.Models
{
    public interface IModelRepo
    {
        Task<Day> GetDay(DateTime day);
        Task AddMaaltijd(Maaltijd maaltijd);
    }
}
