using EetDagboek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace EetDagboek.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods:"GET, POST")]
    public class DagController : ApiController
    {
        ModelRepo db = new ModelRepo();

        [HttpGet]
        public async Task<List<Dag>> GetAllDays()
        {
            return await db.GetAllDays();
        }

        public async Task<Dag> GetDay(DateTime day)
        {
            return await db.GetOneDay(day);
        }

        public async void PostMaaltijd([FromBody]object value)
        {
            await db.AddMaaltijd((Maaltijd)value);
        }
    }

    public class MaaltijdController : ApiController
    {
        ModelRepo db = new ModelRepo();

        [HttpGet]
        public async Task<Maaltijd> GetMaaltijd(DateTime day, string titel)
        {
            return await db.GetMaaltijdByDay(day, titel);
        }

        [HttpGet]
        public async Task<List<Maaltijd>> GetAllMaaltijden(DateTime day)
        {
            return await db.GetAllMaaltijdenByDay(day);
        }

        [HttpPost]
        public async void PostMaaltijd([FromBody]object newMaaltijd)
        {
            await db.AddMaaltijd((Maaltijd)newMaaltijd);
        }
    }
}
