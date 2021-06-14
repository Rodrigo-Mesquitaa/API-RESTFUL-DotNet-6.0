using RegionAPI.Utility;
using System.ComponentModel.DataAnnotations;

namespace RegionAPI.Models
{
    public class MyModel : BaseModel
    {
        [Key]
        public override long Id { get; set; }
        //[Key]
        //public int Id { get; set; }
        public string Name { get; set; }
    }
}
