using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCatalog.Models
{
    public class PlanDeInvatamant : AnDeStudiu
    {
        [Key]
        public int Id { get; set; }
        public char Cod { get; set; }
        private List<Disciplina> Discipline { get; set; }
    }
    
}

