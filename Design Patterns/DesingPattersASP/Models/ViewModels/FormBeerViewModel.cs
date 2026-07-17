using System.ComponentModel.DataAnnotations;

namespace DesingPattersASP.Models.ViewModels
{
    public class FormBeerViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Style { get; set; }
        public Guid? BrandId { get; set; }
        [Display(Name = "Other Brand")]
        public string OtherBrand { get; set; }
    }
}
