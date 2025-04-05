using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API;

[ApiController]
[Route("api/cities")]
public class CitiesController : ControllerBase
{
    [HttpGet]
    public JsonResult GetCities()
    {
        return new JsonResult(
            new List<object>{
                new {id = 1, Name = "Algeria"},
                new {id = 2, Name= "Tunisia"},
                new {id = 3, Name= "Morroco"}
            });
    }
}
