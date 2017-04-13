﻿using System;
using Microsoft.AspNetCore.Mvc;
using ecsCore.Data;
using ecsCore.Domain.POCO;

namespace ecsCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller, IecsCoreController
    {
        private IRepository<Entity> _repo;
        public DataController(IRepository<Entity> repo)
        {
            _repo = repo;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult Get()
        {
            throw new NotImplementedException();
        }

        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult Post([FromBody] HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }
    }
}
