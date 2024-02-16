using System.ComponentModel.DataAnnotations;

namespace yomsAPI.Models
{
    public class Contact
    {
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
