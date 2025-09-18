using DiveDeep.Models;
using System.ComponentModel.DataAnnotations;

namespace DiveDeep.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        [Required(ErrorMessage = "Vælg en startdato")]
        public DateOnly? StartDate { get; set; }
        [Required(ErrorMessage = "Vælg en slutdato")]
        public DateOnly? EndDate { get; set; }
    }
}
