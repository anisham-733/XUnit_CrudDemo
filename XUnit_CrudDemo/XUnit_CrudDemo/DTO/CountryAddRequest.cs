using XUnit_CrudDemo.Entities;

namespace XUnit_CrudDemo.DTO
{
    public class CountryAddRequest
    {
        public string? CountryName { get; set; }
        //Country Add request to country method
        public Country toCountry()
        {
            return new Country()
            {
                countryName= CountryName,
            };
        }
    }
}
