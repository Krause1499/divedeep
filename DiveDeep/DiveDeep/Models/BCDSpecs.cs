using System.ComponentModel.DataAnnotations;

namespace DiveDeep.Models
{
    public record BCDSpecs
    {
        public string? Model { get; set; }
        [Required(ErrorMessage = "Vælg en størrelse")]
        public Size? Size { get; set; }
    }
}
