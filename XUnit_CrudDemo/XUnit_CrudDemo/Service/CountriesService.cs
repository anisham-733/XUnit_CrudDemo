using XUnit_CrudDemo.DTO;
using XUnit_CrudDemo.Entities;

namespace XUnit_CrudDemo.Service
{
    public class CountriesService : ICountriesService
    {
        private readonly List<Country> _countries;
        public CountriesService()
        {
            _countries = new List<Country>();
        }
        public CountryResponse AddCountry(CountryAddRequest countryAddRequest)
        {
            //dto to domain
            Country country = countryAddRequest.toCountry();

            country.countryId = Guid.NewGuid();
            _countries.Add(country);
            //domain to dto
            return new CountryResponse()
            {
                CountryId = country.countryId,
                CountryName = country.countryName,
            };
        


        }
    }
}
