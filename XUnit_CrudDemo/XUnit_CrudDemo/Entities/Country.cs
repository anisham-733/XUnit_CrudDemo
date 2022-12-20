using XUnit_CrudDemo.DTO;

namespace XUnit_CrudDemo.Entities
{
    /// <summary>
/// Domain Model-this model is not directly passed as arg, not directly exposed to presentation layer
/// hence dto
/// </summary>
    public class Country
    {
        public Guid countryId { get; set; }
        public string? countryName { get; set; }

      
    }
}
