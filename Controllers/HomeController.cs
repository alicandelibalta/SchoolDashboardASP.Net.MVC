using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SchoolDashboardMVC.Models;
using SchoolDashboardMVC.View_Models;

namespace SchoolDashboardMVC.Controllers;

public class HomeController : Controller
{

    public static List<StudentVM> StudentList = new List<StudentVM>();

    public static List<TeacherVM> TeacherList = new List<TeacherVM>(); 

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
           
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult ListStudent()
    {
        return View(StudentList);
    }

	public IActionResult ListTeacher()
	{
		return View(TeacherList);
	}


    public IActionResult AddStudent()
    {
        return View();

    }

    [HttpPost]
    public IActionResult AddStudent(CreateStudentVM createdStudent)
    {
        StudentList.Add(createdStudent);
        return View();
    }


    public IActionResult AddTeacher()
    {
        return View();

    }

    [HttpPost]
    public IActionResult AddTeacher(CreateTeacherVM createdTeacher)
    {
     
            TeacherList.Add(createdTeacher);
            return View();

    }


    public IActionResult GetStudentClassList()
    {
        Student student = new()
        {
            Name = "Alican",
            Surname = "Delibalta"

        };

        StudentClass studentClass = new()
        {
            StudentClassName = "HS9"
        };

        StudentClassVM studentClassVM = new()
        {
            Student = student,
            StudentClass = studentClass
        };

        List<StudentClassVM> studentClassVMList = new();

        studentClassVMList.Add(studentClassVM);

        return View(studentClassVMList);
    }








}