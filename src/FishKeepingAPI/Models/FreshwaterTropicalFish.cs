using System.ComponentModel.DataAnnotations;

namespace FishKeepingAPI.Models
{
    public class FishKeepingAPI
    {
        [Key]
        [Required]
        public int Id {get; set;}
        
        [Required]
        public string? CommonName { get; set; }
        [Required]
        public string? ScientificName { get; set; }
        [Required]
        public string? Temperment { get; set; }
        [Required]
        public string? Origin { get; set; }
        [Required]
        public decimal PH { get; set; }
        [Required]
        public int Temp { get; set; }
    }
}