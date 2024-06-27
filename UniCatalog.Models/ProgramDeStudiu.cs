using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCatalog.Models
{
    public class ProgramDeStudiu {
        public CicluDeInvatamant CicluDeInvatamant { get; set; }
        public string Name { get; set; }
        [Key]
        public char Cod;
    }
}
