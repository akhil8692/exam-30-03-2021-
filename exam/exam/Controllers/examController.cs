using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam.Models;

namespace exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class examController : ControllerBase
    {
        private readonly iexamrepository<exammodel> _datarepository;

        public examController(iexamrepository<exammodel> datarepository)
        {
            _datarepository = datarepository;
        }

        [HttpGet]
        public IActionResult get()
        {
            IEnumerable<exammodel> exam = _datarepository.getall();
            return Ok(exam);
        }

        [HttpGet("{id}", Name = "get")]
        public IActionResult get(long id)
        {
            exammodel exam = _datarepository.get(id);
            if(exam==null)
            {
                return NotFound("records not found");
            }
            return Ok(exam);
        }

        [HttpPost]
        public IActionResult post([FromBody] exammodel model)
        {
            if(model==null)
            {
                return BadRequest("records null");
            }
            _datarepository.add(model);
            return CreatedAtRoute(
                "Get",
                new { id = model.id },
                model);
        }

        [HttpDelete("{id}")]
        public IActionResult detete(long id)
        {
            exammodel model = _datarepository.get(id);
            if(model==null)
            {
                return NotFound("no records");
            }
            _datarepository.delete(model);
            return NoContent();
        }

        [HttpPut("{id}")]

        public IActionResult put(long id,[FromBody] exammodel model )
        {
            if(model==null)
            {
                return BadRequest("null");

            }
            exammodel examtoupdate = _datarepository.get(id);
            if(examtoupdate==null)
            {
                return NotFound("record not found");
            }
            _datarepository.update(examtoupdate, model);
            return NoContent();
        }

    }
}
