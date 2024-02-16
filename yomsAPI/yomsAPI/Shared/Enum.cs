using System.ComponentModel.DataAnnotations;

namespace yomsAPI.Shared
{
    public class Enum
    {
        public enum eGender
        {
            Male,

            Female,
        }

        public enum eNationality
        {
            [Display(Name ="South Africa")]
            South_Africa,

            Zimbabwe,

            Swaziland,

            Mozambique,

        }

        public enum eLanguage
        {
            Siswati,

            English,

            Zulu,

            Venda,
 

        }

        public enum eProvince
        {
            Gauteng,

            Mpumalanga,

            Limpopo,

            KZN,

        }

        public enum eRelationship
        {
            Mother,

            Father,

            Brother,

            Sister,
        }

        public enum eQualification
        {

            Certificate,

            Diploma,

            Degree,

            Honours,

            Masters,

            PhD,
        }
    }
}
