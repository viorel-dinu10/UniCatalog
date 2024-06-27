//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UniCatalog.Data.Data;
//using UniCatalog.Data.Repository.IRepository;
//using UniCatalog.Models;

//namespace UniCatalog.Data.Repository
//{
//    public class GrupaRepository : IGrupaRepository
//    {

//        private readonly ApplicationDbContext _context;

//        public GrupaRepository(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public IEnumerable<Grupa> GetAllGroups()
//        {
//            return _context.Grupa.ToList();
//        }

//        public Grupa GetGrupaById(string numarMatricol)
//        {
//            return _context.Grupa.Find(numarMatricol);
//        }

//        public void AddGrupa(Grupa student)
//        {
//            _context.Grupa.Add(student);
//        }

//        public void UpdateGrupa(Grupa student)
//        {
//            _context.Entry(student).State = EntityState.Modified;
//        }

//        public void DeleteGrupa(string numarMatricol)
//        {
//            var student = _context.Grupa.Find(numarMatricol);
//            if (student != null)
//            {
//                _context.Grupa.Remove(student);
//            }
//        }

//        public void Save()
//        {
//            _context.SaveChanges();
//        }

//    }
//}