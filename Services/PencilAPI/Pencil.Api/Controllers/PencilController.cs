using Microsoft.AspNetCore.Mvc;

namespace Pencil.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PencilController : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<Pencil> GetPencil(int id)
    {
        Pencil pencil = new(id);
        return Ok(pencil);
    }
}

public class Pencil
{
    public Pencil(int id)
    {
        Id = id;
        Brand = "Fatih";
        CreatedDate = DateTime.UtcNow;
    }
    public int Id { get; set; }
    public string Brand { get; set; }
    public DateTime CreatedDate { get; set; }
    
}