using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    public class ContactController : ApiController
    {
        ContactRepository repository = new ContactRepository();

        public IHttpActionResult GetAll()
        {
            return Ok(repository.Contacts);
        }


		public IHttpActionResult Get(int id)
		{
			return Ok(repository.GetById(id));
		}
		public IHttpActionResult Post(Contact c)
		{
			repository.Save(c);
			return Ok();
		}
		public IHttpActionResult Put(Contact c)
		{
			repository.Update(c);
			return Ok();
		}
		public IHttpActionResult Delete(int id)
		{
			repository.Delete(id);
			return Ok();
		}
	}
}
