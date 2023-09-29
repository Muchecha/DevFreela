using DevFreelaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreelaAPI.Controllers
{
    [Route("api/projects")]
    public class ProjectsController: Controller
    {
        // api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        // api/projects/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProjectModel)
        {
            if(createProjectModel.Title.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createProjectModel.Id },
                                                                    createProjectModel);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpadateProjectModel upadateProjectModel)
        {
            if(upadateProjectModel.Description.Length > 200)
            {
                return BadRequest();
            }

            return NoContent();
        }

        // api/projects/3 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
