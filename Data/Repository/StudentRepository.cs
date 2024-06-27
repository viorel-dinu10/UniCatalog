using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniCatalog.Data.Data;
using UniCatalog.Data.Repository.IRepository;
using UniCatalog.Models;

namespace UniCatalog.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
       
            private readonly ApplicationDbContext _context;

            public StudentRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public IEnumerable<Student> GetAllStudents()
            {
                return _context.Student.ToList();
            }

            public Student GetStudentById(int numarMatricol)
            {
                return _context.Student.Find(numarMatricol);
            }

            public void AddStudent(Student student)
            {
                _context.Student.Add(student);
            }

            public void UpdateStudent(Student student)
            {
                _context.Entry(student).State = EntityState.Modified;
            }

            public void DeleteStudent(int numarMatricol)
            {
                var student = _context.Student.Find(numarMatricol);
                if (student != null)
                {
                    _context.Student.Remove(student);
                }
            }

            public void Save()
            {
                _context.SaveChanges();
            }
        
    }
}
