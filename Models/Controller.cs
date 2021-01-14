using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

[Route("categorias")]

public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]

    public async Task<ActionResult<List<Category>>> Post([FromBody] Category) => new List<Category();

    [HttpGet]
    [Route("{id:int}")]

    public string GetById(int id)
    {
        return "GET " + id.ToString();
    }

    [HttpPost]
    [Route("")]

    public async Task<ActionResult<List<Category>>> Put(int id, [FromBody] Category)
    {
        if (model.Id == id)
            return ok(model);

        return null();
    }

    [HttpDelete]
    [Route("{id:int}")]

    public string Delete() => Ok();
}
