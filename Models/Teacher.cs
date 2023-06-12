using System.ComponentModel.DataAnnotations;

namespace SchoolDashboardMVC.Models
{
    public class Teacher : BaseModel 
    {

        [StringLength(11)]
        public string TcNumber { get; set; }

        [MaxLength(3)]
        public string Nationality { get; set; }

        [MaxLength(30)]
        public string GraduationSchool { get; set; }
        
        [MaxLength(30)]
        public string GraduationMajor { get; set; }

        public string GraduationYear { get; set; }

        [MaxLength(30)]
        public string Address { get; set; }

        [MaxLength(13)]
        public string PhoneNumber { get; set; }

    }
}
