using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("api/[controller]")]
public class Deneme : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<string> GetPencil(int id)
    {
        return Ok("Ok");
    }
}

