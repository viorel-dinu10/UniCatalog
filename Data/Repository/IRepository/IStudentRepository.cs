using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniCatalog.Models;

namespace UniCatalog.Data.Repository.IRepository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int numarMatricol);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int numarMatricol);
        void Save();
    }
}
