//using Microsoft.AspNetCore.Mvc;
//using UniCatalog.Data.Repository.IRepository;
//using UniCatalog.Models;

//namespace UniCatalog.Areas.User.Controllers
//{
//    [Area("User")]
//    public class GrupaController : Controller
//    {

//        private readonly IGrupaRepository _grupaRepository;
//        private readonly GroupService _groupService;
//        public GrupaController(IGrupaRepository grupaRepository, GroupService groupService)
//        {
//            _grupaRepository = grupaRepository;
//            _groupService = groupService;
//        }


//        public IActionResult Index()
//        {
//            IEnumerable<Grupa>? grupe = _grupaRepository.GetAllGroups();
//            if (!grupe.Any()) 
//            {
//                return RedirectToAction("GenerateGroups",new {nrGrupe = 3});
//            }
            
//                return View(grupe);
            
//        }
//        public IActionResult GenerateGroups(int nrGrupe)
//        {
//            _groupService.GenerateGroups(nrGrupe);
//            return RedirectToAction("Index");
//        }
//    }
//}
