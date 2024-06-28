using Microsoft.AspNetCore.Mvc;
using UniCatalog.Data.Repository.IRepository;
using UniCatalog.Data.Repository;
namespace UniCatalog.Areas.User.Controllers
{
    [Area("User")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly GroupService _groupService;
        public StudentController(IStudentRepository studentRepository, GroupService groupService)
        {
            _studentRepository = studentRepository;
            _groupService = groupService;
        }

        public IActionResult Index()
        {
            var students = _studentRepository.GetAllStudents();
            return View(students);
        }

        public IActionResult GetStudentByGroup()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetStudentByGroup(string Nume)
        {
            var studenti = _studentRepository.GetAllStudents().Where(s => s.GrupaName == Nume).ToList();
            if (studenti.Any())
            {
                return View(studenti);
            }
            return RedirectToAction("Index");
        }


        public IActionResult GenerateGroup(int NrGrupe)
        {
            _groupService.GenerateGroups(NrGrupe);
            return RedirectToAction("Index");
        }
    }
}
