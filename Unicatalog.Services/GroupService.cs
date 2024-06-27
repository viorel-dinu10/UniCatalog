using UniCatalog.Data.Repository.IRepository;
using UniCatalog.Models;
using UniCatalog.Data;

namespace Unicatalog.Services
{
    public class GroupService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IGrupaRepository _grupaRepository;

        public GroupService(IStudentRepository studentRepository, IGrupaRepository grupaRepository)
        {
            _studentRepository = studentRepository;
            _grupaRepository = grupaRepository;
        }



        public void GenerateGroups(int nrGrupe)
        {
            var allStudents = _studentRepository.GetAllStudents().Where(s => s.Grupa == null).ToList();

            for (int i = 0; i < nrGrupe; i++)
            {
                var grupa = new Grupa(i, nrGrupe, allStudents);

                foreach (var student in allStudents)
                {
                    student.Grupa = grupa;
                }
                _grupaRepository.AddGrupa(grupa);
            }
            _studentRepository.Save();
        }

          

    }
}