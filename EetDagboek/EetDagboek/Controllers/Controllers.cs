using EetDagboek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace EetDagboek.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST")]
    public class MaaltijdController : ApiController
    {
        ModelRepo db = new ModelRepo();

        [HttpGet]
        public async Task<List<Maaltijd>> GetAllMaaltijden([FromBody]object day)
        {
            DateTime date = JsonConvert.DeserializeObject<DateTime>(day.ToString());

            return await db.GetAllMaaltijdenByDay((DateTime)day);
        }

        [HttpPost]
        public async void PostMaaltijd([FromBody]object newMaaltijd)
        {
            var mt = JsonConvert.DeserializeObject<Maaltijd>(newMaaltijd.ToString());
            mt.Datum = mt.Datum.Date;

            await db.AddMaaltijd(mt);
        }
    }
}
