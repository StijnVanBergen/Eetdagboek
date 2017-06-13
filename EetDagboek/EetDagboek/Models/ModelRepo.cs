using MongoDB.Driver;
using System;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using System.Collections.Generic;

namespace EetDagboek.Models
{
    public class ModelRepo : IModelRepo
    {
        private readonly DataAccess _context = null;

        public ModelRepo()
        {
            _context = new DataAccess();
        }

        public async Task AddMaaltijd(Maaltijd maaltijd)
        {
            maaltijd.ID = Guid.NewGuid().ToString("N");
            await _context.Maaltijd.InsertOneAsync(maaltijd);
        }

        public async Task<List<Maaltijd>> GetMaaltijdenByDay(DateTime day)
        {
            var output = await _context.Maaltijd.Find(x => x.Datum == day).ToListAsync();
            return output;
        }
    }
}