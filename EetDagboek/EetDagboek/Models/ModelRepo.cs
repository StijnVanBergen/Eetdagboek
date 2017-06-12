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

        public async Task<Day> GetDay(DateTime day)
        {
            return await _context.Dag.Find(x => x.Datum == day).SingleOrDefaultAsync();
        }

        public async Task AddMaaltijd(Maaltijd maaltijd)
        {
            await _context.Maaltijd.InsertOneAsync(maaltijd);
        }
    }
}