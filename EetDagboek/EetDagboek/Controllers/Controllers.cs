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

        [HttpPost]
        public async void Post([FromBody]object value)
        {
            dynamic deserializedValue = JsonConvert.DeserializeObject(value.ToString());
            var date = new DateTime(1970, 01, 01).AddMilliseconds((long)deserializedValue["datum"]).Date;

            Maaltijd myMeal = new Maaltijd()
            {
                Datum = date,
                Gevoel = deserializedValue["Gevoel"],
                Titel = deserializedValue["Titel"],
                Voedsel = deserializedValue["Voedsel"].ToObject<List<string>>()
            };
            await db.AddMaaltijd(myMeal);
        }

        [HttpGet]
        public async Task<string> Get(long id)
        {
            DateTime day = new DateTime(1970, 01, 01).AddMilliseconds(id).Date;
            var output = JsonConvert.SerializeObject(await db.GetMaaltijdenByDay(day));
            return output;
        }
    }
}
