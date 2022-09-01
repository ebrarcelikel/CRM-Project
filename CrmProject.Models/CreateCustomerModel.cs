using System.ComponentModel.DataAnnotations;

namespace CrmProject.Models
{
    public class CreateCustomerModel
    {
        [Required(ErrorMessage="Please provide a {0}")]
        [StringLength(60),Display(Name ="Fullname")]
        public string Fullname { get; set; }


        [Required(ErrorMessage = "Please provide a {0} address")]
        [StringLength(60), Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Please provide a valid {0} address") ]

        public string Email { get; set; }


        [Required(ErrorMessage = "Please provide a {0} number")]
        [StringLength(11), Display(Name = "Phone Number")]
        public string Phone { get; set; }       

        public string Explanation { get; set; }
        public bool Locked { get; set; }
        public bool IsCorporate { get; set; }



    }
}