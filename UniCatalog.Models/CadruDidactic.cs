using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCatalog.Models
{
    public class CadruDidactic
    {
        [Key]
        public string MarcaAngajat { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Titlu { get; set; }
        public Post Post { get; set; }
        [ForeignKey("Disciplina")]
        public string DisciplinaId { get; set; }

    }
}
