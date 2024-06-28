using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniCatalog.Models;

namespace UniCatalog.Data.Repository.IRepository
{
    public interface IPlanDeInvatamantRepository
    {
        IEnumerable<PlanDeInvatamant> GetAllPlans();
        PlanDeInvatamant GetPlanById(int id);
        void AddPlan(PlanDeInvatamant student);
        void UpdatePlan(PlanDeInvatamant student);
        void DeletePlan(int numarMatricol);
        void Save();
    }
}
