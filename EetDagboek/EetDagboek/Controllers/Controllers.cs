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
            Maaltijd meal = JsonConvert.DeserializeObject<Maaltijd>(value.ToString());

            await db.AddMaaltijd(meal);
        }

        [HttpGet]
        public string Get(long id)
        {
            DateTime day = new DateTime(1970, 01, 01).AddMilliseconds(id).Date;
            return JsonConvert.SerializeObject(db.GetDay(day).Result);
        }
    }
}
