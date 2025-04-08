using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API;

[ApiController]
[Route("api/cities")]
public class CitiesController : ControllerBase
{
    [HttpGet]
    public JsonResult GetCities()
    {
        return new JsonResult(CitiesDataStore.Current);
    }

    [HttpGet("{id}")]
    public JsonResult GetCity(int id)
    {
        return new JsonResult(CitiesDataStore.Current.GetCity(id));
    }
}
