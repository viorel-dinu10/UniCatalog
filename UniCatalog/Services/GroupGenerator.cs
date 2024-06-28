using UniCatalog.Data.Repository.IRepository;
using UniCatalog.Models;
using UniCatalog.Data;

namespace UniCatalog
{
    public class GroupService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IPlanDeInvatamantRepository _planRepository;
        private char C;
        private char F = 'F';
        private char P;
        private char A;

        public GroupService(IStudentRepository studentRepository, IPlanDeInvatamantRepository planRepository)
        {
            _studentRepository = studentRepository;
            _planRepository = planRepository;
        }

        public void GenerateGroups(int nrGrupe)
        {
            var studentiAdmisi = _studentRepository.GetAllStudents().Where(s => s.GrupaName == null).ToList();
            int totalStudents = studentiAdmisi.Count;
            int studentsPerGroup = (int)Math.Ceiling((double)totalStudents / nrGrupe);

            int groupCounter = 1;
            int studentCounter = 0;

            foreach (var student in studentiAdmisi)
            {
                if (studentCounter >= studentsPerGroup && groupCounter < nrGrupe)
                {
                    groupCounter++;
                    studentCounter = 0;
                }

                student.PlanDeInvatamant = _planRepository.GetPlanById(student.PlanId);

                if (student.PlanDeInvatamant.CicluDeInvatamant == CicluDeInvatamant.Licenta)
                {
                    C = 'L';
                }
                else
                {
                    C = 'M';
                }

                P = student.PlanDeInvatamant.Cod;
                A = student.DataInscrierii.ToString()[2];
                char Contor = (char)(groupCounter + '0');

                char[] charArray = { '4', C, F, P, A, Contor };
                student.GrupaName = new string(charArray);
                studentCounter++;
            }

            _studentRepository.Save();
        }
    }
}
