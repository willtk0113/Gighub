using System.ComponentModel.DataAnnotations;

namespace Gighub.Models
{
    public class Genre
    {
        //[Key]
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}