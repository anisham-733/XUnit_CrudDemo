using XUnit_CrudDemo.DTO;

namespace XUnit_CrudDemo.Service
{
    public interface ICountriesService
    {
        CountryResponse AddCountry(CountryAddRequest countryAddRequest);
    }
}
