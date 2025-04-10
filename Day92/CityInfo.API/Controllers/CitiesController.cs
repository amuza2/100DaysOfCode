using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API;

[ApiController]
[Route("api/cities")]
public class CitiesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<CityDto>> GetCities()
    {
        return Ok(CitiesDataStore.Current);
    }

    [HttpGet("{id}")]
    public ActionResult<CityDto> GetCity(int id)
    {
        var cityToReturn = CitiesDataStore.Current.GetCity(id);

        if (cityToReturn == null)
            return NotFound();

        return Ok(cityToReturn);
    }
}
