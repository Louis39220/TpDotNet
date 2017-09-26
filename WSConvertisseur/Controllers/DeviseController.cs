using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WSConvertisseur.Models;

namespace WSConvertisseur.Controllers
{
    public class DeviseController : ApiController
    {

        List<Devise> listDevises;

        public DeviseController()
        {
            listDevises = new List<Devise>();

            listDevises.Add(new Devise(1, "Dollar", 1.08));
            listDevises.Add(new Devise(2, "Franc Suisse", 1.07));
            listDevises.Add(new Devise(3, "Yen", 120));
        }

        // GET: api/Devise
        public IQueryable<Devise> Get()
        {
            return listDevises.AsQueryable();
        }

        // GET: api/Devise/5
        [ResponseType(typeof(Devise))]
        public IHttpActionResult Get(int id)
        {
            Devise devise = listDevises.FirstOrDefault((d) => d.id == id);
            if(devise == null)
            {
                return NotFound();
            }
            return Ok(devise);
        }

        // POST: api/Devise
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Devise/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Devise/5
        public void Delete(int id)
        {
        }
    }
}
