using static yomsAPI.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace yomsAPI.DTOs
{
    public class QualificationDTO
    {
        public Guid QualificationId { get; set; }

        [Required]
        [Display(Name = "Highest Qualification")]
        public eQualification HighestQualification { get; set; }

        [Display(Name = "Qualification Name")]
        public string? QualificationName { get; set; }

        [Display(Name = "Year Started")]

        public string YearStarted { get; set; }

        [Display(Name = "Year Completed")]

        public string YearCompleted { get; set; }

    }
}
