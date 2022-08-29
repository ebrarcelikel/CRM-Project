using CrmProject.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrmProject.Entities

{
    [Table("Customers")]

    public class Customer : EntityBase
    {
        [Required, StringLength(60)]
        public string Fullname { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(500)]
        public string Explanation { get; set; }

        public bool Locked { get; set; }
        public bool IsCorporate { get; set; }


        public DateTime createdAt { get; set; }




    }
}