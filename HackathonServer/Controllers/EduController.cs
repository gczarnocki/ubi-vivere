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
    public class EduController : ApiController
    {
        private HackathonContext _db = new HackathonContext();

        // GET api/Edu
        public List<EducationFacility> Get()
        {
            return _db.EducationFacilities.ToList<EducationFacility>();
        }

        // GET api/Edu
        public EducationFacility[] Get(string name)
        {
            return _db.EducationFacilities.Where(x => x.Name.Contains(name)).ToArray<EducationFacility>();
        }

        // GET api/Edu/5
        public EducationFacility Get(int id)
        {
            return _db.EducationFacilities.FirstOrDefault(x => x.Id == id);
        }
    }
}
