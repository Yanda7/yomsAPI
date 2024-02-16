using static yomsAPI.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace yomsAPI.DTOs
{
    public class PersonalInfoDTO
    {
        [Key]
        public Guid PersonId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "ID Number")]
        [Required]
        public string IDNumber { get; set; }

        [Display(Name = "Student Number")]
        [Required]
        public string StudentNo { get; set; }

        public eNationality Nationality { get; set; }

        public eGender Gender { get; set; }

        [Display(Name = "Place Of Birth")]

        public string PlaceOfBirth { get; set; }

        public eLanguage Language { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public bool Disability { get; set; }


        public string? Religion { get; set; }

    }
}
