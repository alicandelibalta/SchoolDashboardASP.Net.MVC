

using System.ComponentModel.DataAnnotations;
using SchoolDashboardMVC.Models;

namespace SchoolDashboardMVC.View_Models;


public class CreateStudentVM : StudentVM
{

	public string StudentNumber { get; set; }

	[Required(ErrorMessage ="Tc number must have 11 character")]
	public string TcNumber { get; set; }

	public string Nationality { get; set; }
}
