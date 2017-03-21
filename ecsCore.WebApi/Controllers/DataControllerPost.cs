using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ecsCore.Data;
using ecsCore.Data.Repositories;
using ecsCore.Domain.POCO;

namespace ecsCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public partial class DataController : Controller
    {
        //EntitiesRepository _repo = new EntitiesRepository();
        private IRepository<Entity> _repo;
        public DataController(IRepository<Entity> repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult Post([FromBody] HttpBodyHeader request)
        {

            switch (request.scheme) {
                case "ecsCore":
                    switch (request.model) {
                        case "Entity":
                            switch (request.verb) {
                                case "get":break;
                                default: return Unauthorized();
                            }
                            break;
                        default: return Unauthorized();
                    }
                    break;
                default: return Unauthorized();
            }

            List<Entity> results = _repo.SelectAll();
            if (results == null) { return NotFound(); }
            return Ok(results);
        }
    }
}
