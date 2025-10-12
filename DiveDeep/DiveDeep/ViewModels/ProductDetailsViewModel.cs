using DiveDeep.Models;
using System.ComponentModel.DataAnnotations;

namespace DiveDeep.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        [Required(ErrorMessage = "Du mangler at vælge en startdato")]
        public DateOnly? StartDate { get; set; }
        [Required(ErrorMessage = "Du mangler at vælge en slutdato")]
        public DateOnly? EndDate { get; set; }
        [Required(ErrorMessage = "Du mangler at vælge en størrelse")]
        public Size? Size { get; set; }
        [Required(ErrorMessage = "Du mangler at vælge et køn")]
        public Gender? Gender { get; set; }
    }
}
