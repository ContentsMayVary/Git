using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("api/simple")]
public class SimpleController : ControllerBase
{
    [HttpGet] // GET api/simple
    public string GetData()
    {
        return "Matthew Watson";
    }

    [HttpGet("{id}")] // GET api/simple/5
    public int GetData(int id)
    {
        return id;
    }
}
