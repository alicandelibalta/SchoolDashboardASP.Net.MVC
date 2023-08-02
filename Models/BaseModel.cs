using System.ComponentModel.DataAnnotations;

namespace SchoolDashboardMVC.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(length: 10, ErrorMessage = "Must be shorter than 10 character!")]
        public string Name { get; set; }

        [MinLength(length:1, ErrorMessage = "Must be greater than 1 character!")]
        [MaxLength(length: 10, ErrorMessage = "Must be shorter than 10 character!")]
        public string Surname { get; set; }

        public int MyProperty { get; set; }

    }
}
