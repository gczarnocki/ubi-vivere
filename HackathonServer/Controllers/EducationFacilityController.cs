using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using HackathonServer.Models;
using Newtonsoft.Json;

namespace HackathonServer.Controllers
{
    public class EducationFacilityController : ApiController
    {
        private HackathonContext _db = new HackathonContext();

        // GET api/EducationFacility
        public List<EducationFacility> Get()
        {
            return _db.EducationFacilities.ToList<EducationFacility>();
        }

        // GET api/EducationFacility
        public EducationFacility[] Get(string name)
        {
            return _db.EducationFacilities.Where(x => x.Name.Contains(name)).ToArray<EducationFacility>();
        }

        // GET api/EducationFacility/5
        public EducationFacility Get(int id)
        {
            return _db.EducationFacilities.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
