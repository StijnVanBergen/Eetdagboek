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
    public class EetDagboekController : ApiController
    {
        ModelRepo db = new ModelRepo();

        [HttpGet]
        public async Task<List<Dag>> GetAllDays()
        {
            return await db.GetAllDays();
        }

        public string Get(int id)
        {
            return "value";
        }

        public async void PostMaaltijd([FromBody]object value)
        {
            await db.AddMaaltijd((Maaltijd)value);
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
