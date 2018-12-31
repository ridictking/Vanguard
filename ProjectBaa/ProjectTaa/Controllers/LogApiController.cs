using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTaa.Data;
using ProjectTaa.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectTaa.Controllers
{
    [Route("api/[controller]")]
    public class LogApiController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LogApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        //[HttpGet]
        ////public IEnumerable<string> Get()
        ////{
        ////    return new string[] { "value1", "value2" };
        ////}

        [HttpGet]
        public IEnumerable<Log> Get()
        {
            return _context.Log.ToList();
        }
        // GET api/<controller>/5
        [HttpGet("{id}", Name = "GetLog")]
        public ActionResult<Log> GetById(int id)
        {
            var item = _context.Log.Find(id);

            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
