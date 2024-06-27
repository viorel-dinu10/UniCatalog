using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCatalog.Models
{
    public class Disciplina
    {
        [Key]
        public string Cod { get; set; }
        public string Name { get; set; }
        public string Acronim { get; set; }
        public int Credite { get; set; }
        [ForeignKey("Plan")]
        public int? PlanId { get; set; }


    }
}
