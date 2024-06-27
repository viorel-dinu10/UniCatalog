using Microsoft.AspNetCore.Mvc;
using UniCatalog.Data.Repository.IRepository;
using UniCatalog.Data.Repository;
namespace UniCatalog.Areas.User.Controllers
{
    [Area("User")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            var students = _studentRepository.GetAllStudents();
            return View(students);
        }

    }
}
