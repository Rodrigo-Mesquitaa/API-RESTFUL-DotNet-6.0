using System.ComponentModel.DataAnnotations;

namespace RegionAPI.ViewModels
{
    public class MyModelViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
