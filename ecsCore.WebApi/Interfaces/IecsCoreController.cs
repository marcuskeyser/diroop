using Microsoft.AspNetCore.Mvc;
using ecsCore.Domain.POCO;


namespace ecsCore.WebApi
{
    public interface IecsCoreController
    {
        // GET api/values
        [HttpGet()]
        IActionResult Get();
        // GET api/values/5
        [HttpGet("{id}")]
        string Get(int id);
        //POST api/values
        [HttpPost]
        IActionResult Post([FromBody] HttpBodyHeader request);
        // PUT api/values/5
        [HttpPut("{id}")]
        void Put(int id, [FromBody]string value);
        // DELETE api/values/5
        [HttpDelete("{id}")]
        void Delete(int id);

    }
}
