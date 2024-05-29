using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarPlugApi.Model
{
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }
        public string Name { get; set; }

        public ICollection<University> universities { get; set; }
    }
}
