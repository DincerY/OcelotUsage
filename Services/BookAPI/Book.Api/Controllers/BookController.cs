using Microsoft.AspNetCore.Mvc;

namespace Book.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(int id)
    {
        Book book = new(id);
        
        return Ok(book);
    }
    
}

public class Book
{
    public Book(int id)
    {
        Random random = new();
        Id = id;
        Name = "Kucuk Prens";
        Barkod = random.Next(0,100);
        PageSize = random.Next(0, 500);
        Author = "Dincer Yigit";
    }
    public int Id { get; set; }
    public int Barkod { get; set; }
    public string Name { get; set; }
    public int PageSize { get; set; }
    public string Author { get; set; }
}