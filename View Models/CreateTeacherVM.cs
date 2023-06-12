using System.ComponentModel.DataAnnotations;

namespace SchoolDashboardMVC.View_Models
{
	public class CreateTeacherVM : TeacherVM
	{
		public string TcNumber { get; set; }
		public string Nationality { get; set; }
		public string GraduationSchool { get; set; }
		public string GraduationMajor { get; set; }
		public string GraduationYear { get; set; }
	}
}
