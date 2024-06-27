//using UniCatalog.Data.Repository.IRepository;
//using UniCatalog.Models;
//using UniCatalog.Data;

//namespace UniCatalog
//{
//    public class GroupService
//    {
//        private readonly IStudentRepository _studentRepository;
//        private readonly IGrupaRepository _grupaRepository;
//        private char C;
//        private char F = 'F';
//        private char P;
//        private char A;
//        private char Contor;
//        public GroupService(IStudentRepository studentRepository, IGrupaRepository grupaRepository)
//        {
//            _studentRepository = studentRepository;
//            _grupaRepository = grupaRepository;
//        }



//        public void GenerateGroups(int nrGrupe)
//        {
//            var allStudents = _studentRepository.GetAllStudents().Where(s => s.Grupa == null).ToList();
//            if (allStudents[0].CicluDeInvatamant == CicluDeInvatamant.Licenta)
//            {
//                C = 'L';
//            }
//            else
//            {
//                C = 'M';
//            }

//            P = allStudents[0].Cod;
//            //A = allStudents[1].Cod;
//            for (int i = 0; i < nrGrupe; i++)
//            {
//                var grupa = new Grupa(i, nrGrupe, allStudents);

//                foreach (var student in allStudents)
//                {
//                    student.Grupa = grupa;
//                }
               
//            }
//            _studentRepository.Save();
//        }



//    }
//}