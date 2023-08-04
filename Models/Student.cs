using System.ComponentModel.DataAnnotations;

namespace SchoolDashboardMVC.Models
{
    public class Student : BaseModel
    {
        [Required, Range(10,15) ]
        public string StudentNumber { get; set; }

        [Range(11,11)]
        public string TcNumber { get; set; }

        [MaxLength(3)]
        public string Nationality { get; set; }

        [MaxLength(30)]
        public string Address { get; set; }

        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        StudentClass StudentClass { get; set; }

        //github deneme propu
        public int MyProperty1 { get; set; }

        //blabla yeni commit için deneme
    }
}
