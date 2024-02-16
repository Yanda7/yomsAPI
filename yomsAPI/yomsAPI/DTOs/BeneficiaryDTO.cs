using static yomsAPI.Shared.Enum;

namespace yomsAPI.DTOs
{
    public class BeneficiaryDTO
    {
        public Guid BeneficiaryId { get; set; }

        public string BeneficiaryName { get; set; }

        public string BenSurname { get; set; }

        public string BenCellphone { get; set; }

        public eRelationship Relationship { get; set; }
    }
}
