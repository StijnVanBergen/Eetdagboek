using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using MongoDB.Driver.Linq;

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

        public async Task<List<Maaltijd>> GetAllMaaltijdenByDay(DateTime day)
        {
            return await _context.Maaltijd.Find(x => x.Dag.Datum == day).ToListAsync();
        }

        public async Task<Maaltijd> GetMaaltijdByDay(DateTime day, string titel)
        {
            var query = from x in _context.Maaltijd.AsQueryable()
                        where x.Dag.Datum == day
                        where x.Titel == titel
                        select x;                        

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Dag> GetOneDay(DateTime dag)
        {
            return await _context.Dag.Find(x => x.Datum == dag).FirstOrDefaultAsync();
        }
    }
}