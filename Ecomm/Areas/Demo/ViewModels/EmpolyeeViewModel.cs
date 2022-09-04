using System;
using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Areas.Demo.ViewModels
{
    public class EmpolyeeViewModel
    {
        


        [Display(Name = "Empolyee Name")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        [MaxLength(80, ErrorMessage = "{0} can contain a maxium of {1} characters.")]
        [MinLength(2, ErrorMessage = "{0} should contain a minimum of {1} characters.")]
        public string EmpolyeeName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "{0} is not valid.")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage ="{0} Cannot be Empty")]
        [Phone(ErrorMessage ="{0} Must be number")]
        public int PhoneNumber { get; set; }


        [Display(Name = "Birth Date")]
        [Required]
        public DateTime BirthDate { get; set; }


        [Display(Name ="Gender")]
        [Required(ErrorMessage = "{0} Cannot be empty")]
         public string Gender { get; set; }


        [Display(Name = "Address")]
        [Required(ErrorMessage = "{0} Cannot be empty")]
        public string Address { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "{0} Cannot be empty")]
        public string Password { get; set; }

    }
}
