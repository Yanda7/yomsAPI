using System.ComponentModel.DataAnnotations;
using static yomsAPI.Shared.Enum;

namespace yomsAPI.Models
{
    public class Qualification
    {
        public Guid QualificationId { get; set; }

        [Required]
        [Display(Name = "Highest Qualification")]
        public eQualification HighestQualification {  get; set; }

        [Display(Name = "Qualification Name")]
        public string? QualificationName { get; set; }

        [Display(Name = "Year Started")]

        public string YearStarted { get; set; }

        [Display(Name = "Year Completed")]

        public string YearCompleted { get; set; }



    }
}
