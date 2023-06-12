


using System.ComponentModel.DataAnnotations;

namespace SchoolDashboardMVC.Models;

public class StudentClass 
{
    public int Id { get; set; }

    [Required, Range(1,3)]
    public string StudentClassName { get; set; }

  

}
