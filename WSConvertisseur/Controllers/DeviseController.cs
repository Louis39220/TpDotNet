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

        private static List<Devise> listDevises = new List<Devise>();

        public DeviseController()
        { 

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
        [ResponseType(typeof(Devise))]
        public IHttpActionResult Post(Devise devise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            listDevises.Add(devise);
            return CreatedAtRoute("DefaultApi", new { id = devise.id }, devise);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Devise devise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != devise.id)
            {
                return BadRequest();
            }
            int index = listDevises.FindIndex((d) => d.Id == id);
            if (index < 0)
            {
                return NotFound();
            }
            listDevises[index] = devise;
            return StatusCode(HttpStatusCode.NoContent);
        }

            // DELETE: api/Devise/5
            public void Delete(int id)
        {
        }
    }
}
