using XUnit_CrudDemo.Entities;

namespace XUnit_CrudDemo.DTO
{
    /// <summary>
    /// Convert the country object to countryresponse
    /// </summary>
    public class CountryResponse
    {
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
        public CountryResponse toCountryResponse( Country country)
        {
            return new CountryResponse()
            {
                CountryId = country.countryId,
                CountryName = country.countryName,
            };
        }
    }
}
