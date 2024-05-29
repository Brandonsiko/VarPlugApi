using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarPlugApi.Model
{
    public class University
    {
        [Key]
        public int UNI_Id { get; set; }
        public string UNI_Name { get; set; }
        public string UNI_Description { get; set; }

        public ICollection<Faculty> OfferedFaculties { get; set; }
        public string Website { get; set; }
        public string Application { get; set; }
        public string Portal { get; set; }
        public string Phone { get; set; }

        [ForeignKey("Province")]
        public int ProvinceId { get; set; }
        public Province province { get; set; }
    }
}
