using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EetDagboek.Models
{
    public class ModelRepo : IModelRepo
    {
        private readonly DataAccess _context = null;

        public ModelRepo()
        {
            _context = new DataAccess();
        }

        public async Task AddDag(Dag dag)
        {
            await _context.Dag.InsertOneAsync(dag);
        }

        public async Task AddMaaltijd(Maaltijd maaltijd)
        {
            await _context.Maaltijd.InsertOneAsync(maaltijd);
        }

        public async Task<List<Dag>> GetAllDays()
        {
            return await _context.Dag.Find(_ => true).ToListAsync();
        }

        public async Task<Maaltijd> GetMaaltijdByDay(DateTime day)
        {
            return await _context.Maaltijd.Find(x => x.Dag.Datum == day).FirstOrDefaultAsync();
        }

        public async Task<Maaltijd> GetMaaltijdenByID(int DagID)
        {
            return await _context.Maaltijd.Find(x => x.ID == DagID).FirstOrDefaultAsync();
        }

        public async Task<Dag> GetOneDay(DateTime dag)
        {
            return await _context.Dag.Find(x => x.Datum == dag).FirstOrDefaultAsync();
        }
    }
}