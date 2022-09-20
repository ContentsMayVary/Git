using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("api/simple")]
public class SimpleController : ControllerBase
{
    [HttpGet]
    public string GetData()
    {
        return "X Matthew Watson";
    }
}
