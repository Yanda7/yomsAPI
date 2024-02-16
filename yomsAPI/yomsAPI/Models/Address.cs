using System.ComponentModel.DataAnnotations;
using static yomsAPI.Shared.Enum;

namespace yomsAPI.Models
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }

        public string StreetName { get; set; }   

        public string City { get; set; }

        public string Surburb {  get; set; }

        public string Code { get; set; }

        public eProvince Province { get; set; }
    }
}
