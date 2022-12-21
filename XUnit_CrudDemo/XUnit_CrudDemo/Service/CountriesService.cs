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
            //Validation 1
            if (countryAddRequest == null)
            {
                throw new ArgumentNullException(nameof(countryAddRequest));
            }
            //Validation 2
            if (countryAddRequest.CountryName == null)
            {
                throw new ArgumentException(nameof(countryAddRequest.CountryName));
            }

            //Validation 3 can also be like chekcing for duplicate country names
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
