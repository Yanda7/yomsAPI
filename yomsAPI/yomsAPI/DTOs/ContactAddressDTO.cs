using System.ComponentModel.DataAnnotations;
using static yomsAPI.Shared.Enum;

namespace yomsAPI.DTOs
{
    public class ContactAddressDTO
    {
        public Guid AddressId { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string Surburb { get; set; }

        public string Code { get; set; }

        public eProvince Province { get; set; }

        [Key]
        public Guid ContactId { get; set; }

        [MaxLength(10)]
        [MinLength(3)]
        [DataType(DataType.PhoneNumber)]
        public string Cellphone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Telephone { get; set; }

    }
}
