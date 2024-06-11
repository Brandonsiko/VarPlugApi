using System.ComponentModel.DataAnnotations;

namespace VarPlugApi.Model
{
    public class CareerUniverities
    {
        [Key]
        public int CareerUniversityId { get; set; }
        public int CareerId { get; set; }
        public Career Career { get; set; }

        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}
