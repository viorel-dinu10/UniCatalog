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
    public class PlanDeInvatamantRepository : IPlanDeInvatamantRepository
    {

        private readonly ApplicationDbContext _context;

        public PlanDeInvatamantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PlanDeInvatamant> GetAllPlans()
        {
            return _context.PlanuriDeInvatamant.ToList();
        }

        public PlanDeInvatamant GetPlanById(int numarMatricol)
        {
            return _context.PlanuriDeInvatamant.Find(numarMatricol);
        }

        public void AddPlan(PlanDeInvatamant student)
        {
            _context.PlanuriDeInvatamant.Add(student);
        }

        public void UpdatePlan(PlanDeInvatamant student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }

        public void DeletePlan(int numarMatricol)
        {
            var student = _context.PlanuriDeInvatamant.Find(numarMatricol);
            if (student != null)
            {
                _context.PlanuriDeInvatamant.Remove(student);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
