using System.ComponentModel.DataAnnotations;

namespace yomsAPI.Models
{
    public class HighestGrade
    {
        [Key]
        public Guid HighestGradeId { get; set; }

        [Display(Name ="Highest Grade Passed")]
        public string HighestGradePassed { get; set; }

        [Display(Name ="Year Obtained")]
        public string YearObtained { get; set; }

        [Display(Name ="Name Of School")]
        public string NameOfSchool { get; set; }

    }
}
