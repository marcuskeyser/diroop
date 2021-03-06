﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ecsCore.Data;
using ecsCore.Data.Repositories;
using ecsCore.Domain.POCO;

namespace ecsCore.WebApi.Controllers
{
    //[Route("api/[controller]")]
    public partial class DataController : Controller
    {
        [HttpPost]
        public JsonResult Post([FromBody]string value)
        {
            EntitiesRepository repo = new EntitiesRepository();
            return new JsonResult(repo.SelectAll());
        }
    }
}
