using System.ComponentModel.DataAnnotations;

namespace FishKeepingAPI.Models
{
    public class FreshwaterTropicalFish
    {
        [Key]
        [Required]
        public int Id {get; set;}
        
        [Required]
        [MaxLength(30)]
        public string? CommonName { get; set; }
        [Required]
        [MaxLength(60)]
        public string? ScientificName { get; set; }
        [Required]
        public string? Family { get; set; }
        
        [Required]
        public string? Temperment { get; set; }
        [Required]
        public string? Origin { get; set; }
        [Required]
        public float PH { get; set; }
        [Required]
        public int Temp { get; set; }
    }
}