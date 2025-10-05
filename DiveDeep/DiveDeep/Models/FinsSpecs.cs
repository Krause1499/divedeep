using System.ComponentModel.DataAnnotations;

namespace DiveDeep.Models
{
    public record FinsSpecs
    {
        public string? Model { get; set; }
        //[Required(ErrorMessage = "Vælg en størrelse")]
        public IReadOnlyList<Size>? Sizes { get; set; } = Array.Empty<Size>();
    }
}
