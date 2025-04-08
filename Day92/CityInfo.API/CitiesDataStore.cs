namespace CityInfo.API;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }
    public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name = "Tipaza",
                Description = "Roman ruins"
            },
            new CityDto()
            {
                Id = 2,
                Name = "Blida",
                Description = "Flower city"
            },
            new CityDto()
            {
                Id = 3,
                Name = "Oran",
                Description = "Karantita"
            },
        };
    }

    public CityDto? GetCity(int id)
    {
        return Cities.FirstOrDefault(c => c.Id == id);
    }

}
