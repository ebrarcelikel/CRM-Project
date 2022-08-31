namespace CrmProject.Models
{
    public class CreateCustomerModel
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Explanation { get; set; }
        public bool Locked { get; set; }
        public bool IsCorporate { get; set; }



    }
}