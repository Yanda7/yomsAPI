using static yomsAPI.Shared.Enum;

namespace yomsAPI.Models
{
    public class Beneficiary
    {
        public Guid BeneficiaryId { get; set; }

        public string BeneficiaryName { get; set;}

        public string BenSurname { get; set;}

        public string BenCellphone { get; set;}

        public eRelationship Relationship { get; set;}

    }
}
