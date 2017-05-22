using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EetDagboek.Models
{
    public class ModelRepo : IModelRepo
    {
        public Task AddDag(Dag dag)
        {
            throw new NotImplementedException();
        }

        public Task AddMaaltijd(Maaltijd maaltijd)
        {
            throw new NotImplementedException();
        }

        public Task<List<Dag>> GetAllDays()
        {
            throw new NotImplementedException();
        }

        public Task<Maaltijd> GetMaaltijdByDay(DateTime day)
        {
            throw new NotImplementedException();
        }

        public Task<Maaltijd> GetMaaltijdenByID(int DagID)
        {
            throw new NotImplementedException();
        }

        public Task<Dag> GetOneDay()
        {
            throw new NotImplementedException();
        }
    }
}