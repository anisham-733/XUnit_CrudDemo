using XUnit_CrudDemo.DTO;
using XUnit_CrudDemo.Service;

namespace XUnit_CrudDemo
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _service;
        public CountriesServiceTest()
        {
            _service = new CountriesService();
        }
        //when CountryAddRequest is null, its should throw ArgumentNullException
        //when CountryAddRequest is duplicate, its should throw ArgumentException
        //everthing well--insert

        [Fact]
        public void AddCountry_NullCountry()
        {
            //Arrange
            CountryAddRequest _request = null;

           

            //aSSERT
            Assert.Throws<ArgumentNullException>(() => //Act
                                                       _service.AddCountry(_request));
        }

        [Fact]
        public void AddCountry_CountryNameisNull() 
        {
            CountryAddRequest _request = new CountryAddRequest()
            {
                CountryName = null
            };
        Assert.Throws<ArgumentException> (()=> _service.AddCountry(_request));
        }
        [Fact]
        public void AddCountry_ProperCountryName()
        {
            CountryAddRequest _req = new CountryAddRequest()
            {
                CountryName = "Japan"
        };
            CountryResponse countryResponse= _service.AddCountry(_req);
            Assert.True(countryResponse.CountryId!= Guid.Empty);

        }
    }
}
