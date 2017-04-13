﻿using System;
using ecsCore.Domain.POCO;
using Microsoft.AspNetCore.Mvc;
using ecsCore.Data;
using System.Collections.Generic;


namespace ecsCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller, IecsCoreController
    {
        private IRepository<Customer> _repo;
        public CustomerController(IRepository<Customer> repo)
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

        [HttpPost]
        public IActionResult Post([FromBody] HttpBodyHeader request)
        {
            List<Customer> results = _repo.SelectAll(request);
            if (results == null) { return NotFound(); }
            return Ok(results);
        }

        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }
    }
}