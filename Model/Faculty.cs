using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarPlugApi.Model
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("University")]
        public int UniversityId { get; set; }
        public University university { get; set; }

        public ICollection<Career> Careers { get; set; }

        public ICollection<CareerFaculty> careerFaculties { get; set; }

    }
}
