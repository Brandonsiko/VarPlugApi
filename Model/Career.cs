using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarPlugApi.Model
{
    public class Career
    {
        [Key]
        public int Career_Id { get; set; }
        public string Career_Name { get; set; }

        public string Discription { get; set; }

        
        public ICollection<CareerUniverities> CareerUniversities { get; set; }

        public ICollection<CareerFaculty> careerFaculties { get; set; }


        public ICollection<Faculty> faculties { get; set; }
    }
}
