using System.ComponentModel.DataAnnotations;

namespace DiveDeep.Models
{
    public record DivingSuitSpecs
    {
        public string? Model { get; set; }
        [Required(ErrorMessage = "Vælg en størrelse")]
        public Size? Size { get; set; }
        public SuitType? SuitType { get; set; }
        [Required(ErrorMessage = "Vælg et køn")]
        public Gender? Gender { get; set; }
        public double? ThicknessInMm { get; set; }

    }
}
