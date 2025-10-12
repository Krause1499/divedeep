using System.ComponentModel.DataAnnotations;

namespace DiveDeep.Models
{
    public record BCDSpecs
    {
        public string? Model { get; set; }
        public IReadOnlyList<Size>? Sizes { get; set; } = Array.Empty<Size>();
    }
}
