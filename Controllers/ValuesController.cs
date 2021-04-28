using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandyApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HandyApp.Controllers
{


    // API for JavaScript calls 

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {



        private readonly ApplicationDbContext _db;

        public ValuesController(ApplicationDbContext db)
        {
            _db = db;
        }




        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable Get()
        {
            return _db.Customers;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
