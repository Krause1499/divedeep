using System.ComponentModel.DataAnnotations;

namespace DiveDeep.Models
{
    public record DivingSuitSpecs
    {
        public string? Model { get; set; }
        //[Required(ErrorMessage = "Vælg en størrelse")]
        public IReadOnlyList<Size>? Sizes { get; set; } = Array.Empty<Size>();
        public SuitType? SuitType { get; set; }
        //[Required(ErrorMessage = "Vælg et køn")]
        public IReadOnlyList<Gender>? Genders { get; set; } = Array.Empty<Gender>();
        public double? ThicknessInMm { get; set; }

    }
}
