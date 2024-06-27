using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniCatalog.Models;

namespace UniCatalog.Data.Repository.IRepository
{
    public interface IGrupaRepository
    {
        //IEnumerable<Grupa> GetAllGroups();
        Grupa GetGrupaById(string numarMatricol);
        void AddGrupa(Grupa student);
        void UpdateGrupa(Grupa student);
        void DeleteGrupa(string numarMatricol);
        void Save();
    }
}